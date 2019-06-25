/*
 * Copyright (c) 2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.Models;
using Piranha.Manager.Models;
using Piranha.Manager.Models.Content;
using Piranha.Services;

namespace Piranha.Manager.Services
{
    public class PageService
    {
        private readonly IApi _api;
        private readonly IContentFactory _factory;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="api">The current api</param>
        public PageService(IApi api, IContentFactory factory)
        {
            _api = api;
            _factory = factory;
        }

        /// <summary>
        /// Gets the list model.
        /// </summary>
        /// <returns>The list model</returns>
        public async Task<PageListModel> GetList()
        {
            var model = new PageListModel
            {
                Sites = (await _api.Sites.GetAllAsync()).Select(s => new PageListModel.SiteItem
                {
                    Id = s.Id,
                    Title = s.Title,
                    Slug = "/",
                    EditUrl = "manager/site/"
                }).ToList(),
                PageTypes = App.PageTypes.Select(t => new PageListModel.PageTypeItem
                {
                    Id = t.Id,
                    Title = t.Title,
                    AddUrl = "manager/page/add/"
                }).ToList()
            };

            foreach (var site in model.Sites)
            {
                var sitemap = await _api.Sites.GetSitemapAsync(site.Id, false);

                foreach (var item in sitemap)
                {
                    site.Pages.Add(MapRecursive(item));
                }
            }

            return model;
        }

        public async Task<PageEditModel> Create(string typeId)
        {
            var page = _api.Pages.Create<DynamicPage>(typeId);

            page.Id = Guid.NewGuid();
            page.SiteId = (await _api.Sites.GetDefaultAsync()).Id;
            page.SortOrder = (await _api.Sites.GetSitemapAsync(page.SiteId)).Count;

            if (page != null)
            {
                return Transform(page, false);
            }
            return null;
        }

        public async Task<PageEditModel> GetById(Guid id, bool useDraft = true)
        {
            var isDraft = true;
            var page = useDraft ? await _api.Pages.GetDraftByIdAsync(id) : null;

            if (page == null)
            {
                page = await _api.Pages.GetByIdAsync(id);
                isDraft = false;
            }

            if (page != null)
            {
                return Transform(page, isDraft);
            }
            return null;
        }

        public async Task Save(PageEditModel model, bool draft)
        {
            var pageType = App.PageTypes.GetById(model.TypeId);

            if (pageType != null)
            {
                if (model.Id == Guid.Empty)
                {
                    model.Id = Guid.NewGuid();
                }

                var page = await _api.Pages.GetByIdAsync(model.Id);

                if (page == null)
                {
                    page = _factory.Create<DynamicPage>(pageType);
                    page.Id = model.Id;
                }

                page.SiteId = model.SiteId;
                page.ParentId = model.ParentId;
                page.SortOrder = model.SortOrder;
                page.TypeId = model.TypeId;
                page.Title = model.Title;
                page.NavigationTitle = model.NavigationTitle;
                page.Slug = model.Slug;
                page.MetaKeywords = model.MetaKeywords;
                page.MetaDescription = model.MetaDescription;
                page.Published = !string.IsNullOrEmpty(model.Published) ? DateTime.Parse(model.Published) : (DateTime?)null;

                // Save regions
                foreach (var region in pageType.Regions)
                {
                    var modelRegion = model.Regions
                        .FirstOrDefault(r => r.Meta.Id == region.Id);

                    if (region.Collection)
                    {
                        var listRegion = (IRegionList)((IDictionary<string, object>)page.Regions)[region.Id];

                        listRegion.Clear();

                        foreach (var item in modelRegion.Items)
                        {
                            if (region.Fields.Count == 1)
                            {
                                listRegion.Add(item.Fields[0].Model);
                            }
                            else
                            {
                                var pageRegion = new ExpandoObject();

                                foreach (var field in region.Fields)
                                {
                                    var modelField = item.Fields
                                        .FirstOrDefault(f => f.Meta.Id == field.Id);
                                    ((IDictionary<string, object>)pageRegion)[field.Id] = modelField.Model;
                                }
                                listRegion.Add(pageRegion);
                            }
                        }
                    }
                    else
                    {
                        var pageRegion = ((IDictionary<string, object>)page.Regions)[region.Id];

                        if (region.Fields.Count == 1)
                        {
                            ((IDictionary<string, object>)page.Regions)[region.Id] =
                                modelRegion.Items[0].Fields[0].Model;
                        }
                        else
                        {
                            foreach (var field in region.Fields)
                            {
                                var modelField = modelRegion.Items[0].Fields
                                    .FirstOrDefault(f => f.Meta.Id == field.Id);
                                ((IDictionary<string, object>)pageRegion)[field.Id] = modelField.Model;
                            }
                        }
                    }
                }

                // Save blocks
                page.Blocks.Clear();

                foreach (var block in model.Blocks)
                {
                    if (block is BlockGroupModel blockGroup)
                    {
                        var groupType = App.Blocks.GetByType(blockGroup.Type);

                        if (groupType != null)
                        {
                            var pageBlock = (Extend.BlockGroup)Activator.CreateInstance(groupType.Type);

                            pageBlock.Id = blockGroup.Id;
                            pageBlock.Type = blockGroup.Type;

                            foreach (var field in blockGroup.Fields)
                            {
                                var prop = pageBlock.GetType().GetProperty(field.Meta.Id, App.PropertyBindings);
                                prop.SetValue(pageBlock, field.Model);
                            }

                            foreach (var item in blockGroup.Items)
                            {
                                pageBlock.Items.Add(item.Model);
                            }
                            page.Blocks.Add(pageBlock);
                        }
                    }
                    else if (block is BlockItemModel blockItem)
                    {
                        page.Blocks.Add(blockItem.Model);
                    }
                }

                // Save page
                if (draft)
                {
                    await _api.Pages.SaveDraftAsync(page);
                }
                else
                {
                    await _api.Pages.SaveAsync(page);
                }
            }
            else
            {
                throw new ValidationException("Invalid Page Type.");
            }
        }

        /// <summary>
        /// Deletes the page with the given id.
        /// </summary>
        /// <param name="id">The unique id</param>
        public Task Delete(Guid id)
        {
            return _api.Pages.DeleteAsync(id);
        }

        private PageListModel.PageItem MapRecursive(SitemapItem item)
        {
            var model = new PageListModel.PageItem
            {
                Id = item.Id,
                Title = item.MenuTitle,
                TypeName = item.PageTypeName,
                Published = item.Published.HasValue ? item.Published.Value.ToString("yyyy-MM-dd") : null,
                Status = !item.Published.HasValue ? PageListModel.PageItem.Unpublished : "",
                EditUrl = "manager/page/edit/"
            };

            foreach (var child in item.Items)
            {
                model.Items.Add(MapRecursive(child));
            }
            return model;
        }

        private PageEditModel Transform(DynamicPage page, bool isDraft)
        {
            var type = App.PageTypes.GetById(page.TypeId);

            var model = new PageEditModel
            {
                Id = page.Id,
                SiteId = page.SiteId,
                ParentId = page.ParentId,
                SortOrder = page.SortOrder,
                TypeId = page.TypeId,
                Title = page.Title,
                NavigationTitle = page.NavigationTitle,
                Slug = page.Slug,
                MetaKeywords = page.MetaKeywords,
                MetaDescription = page.MetaDescription,
                Published = page.Published.HasValue ? page.Published.Value.ToString("yyyy-MM-dd HH:mm") : null,
                State = GetState(page, isDraft),
                UseBlocks = type.UseBlocks
            };

            foreach (var regionType in type.Regions)
            {
                var region = new RegionModel
                {
                    Meta = new RegionMeta
                    {
                        Id = regionType.Id,
                        Name = regionType.Title,
                        Description = regionType.Description,
                        Placeholder = regionType.ListTitlePlaceholder,
                        IsCollection = regionType.Collection,
                        Icon = regionType.Icon,
                        Display = regionType.Display.ToString().ToLower()
                    }
                };
                var regionListModel = ((IDictionary<string, object>)page.Regions)[regionType.Id];

                if (!regionType.Collection)
                {
                    var regionModel = (IRegionList)Activator.CreateInstance(typeof(RegionList<>).MakeGenericType(regionListModel.GetType()));
                    regionModel.Add(regionListModel);
                    regionListModel = regionModel;
                }

                foreach (var regionModel in (IEnumerable)regionListModel)
                {
                    var regionItem = new RegionItemModel();

                    foreach (var fieldType in regionType.Fields)
                    {
                        var appFieldType = App.Fields.GetByType(fieldType.Type);

                        var field = new FieldModel
                        {
                            Meta = new FieldMeta
                            {
                                Id = fieldType.Id,
                                Name = fieldType.Title,
                                Component = appFieldType.Component,
                                Placeholder = fieldType.Placeholder,
                                IsHalfWidth = fieldType.Options.HasFlag(FieldOption.HalfWidth),
                                Description = fieldType.Description
                            }
                        };

                        if (regionType.Fields.Count > 1)
                        {
                            field.Model = (Extend.IField)((IDictionary<string, object>)regionModel)[fieldType.Id];

                            if (regionType.ListTitleField == fieldType.Id)
                            {
                                regionItem.Title = field.Model.GetTitle();
                                field.Meta.NotifyChange = true;
                            }
                        }
                        else
                        {
                            field.Model = (Extend.IField)regionModel;
                            field.Meta.NotifyChange = true;
                            regionItem.Title = field.Model.GetTitle();
                        }
                        regionItem.Fields.Add(field);
                    }

                    if (string.IsNullOrWhiteSpace(regionItem.Title))
                    {
                        regionItem.Title = "...";
                    }

                    region.Items.Add(regionItem);
                }
                model.Regions.Add(region);
            }

            foreach (var block in page.Blocks)
            {
                var blockType = App.Blocks.GetByType(block.Type);

                if (block is Extend.BlockGroup)
                {
                    var group = new BlockGroupModel
                    {
                        Id = block.Id,
                        Type = block.Type,
                        Meta = new BlockMeta
                        {
                            Name = blockType.Name,
                            Icon = blockType.Icon,
                            Component = "block-group",
                            IsGroup = true
                        }
                    };

                    if (blockType.Display != BlockDisplayMode.MasterDetail)
                    {
                        group.Meta.Component = blockType.Display == BlockDisplayMode.Horizontal ?
                            "block-group-horizontal" : "block-group-vertical";
                    }

                    foreach (var prop in block.GetType().GetProperties(App.PropertyBindings))
                    {
                        if (typeof(Extend.IField).IsAssignableFrom(prop.PropertyType))
                        {
                            var fieldType = App.Fields.GetByType(prop.PropertyType);

                            group.Fields.Add(new FieldModel
                            {
                                Model = (Extend.IField)prop.GetValue(block),
                                Meta = new FieldMeta
                                {
                                    Id = prop.Name,
                                    Name = prop.Name,
                                    Component = fieldType.Component,
                                }
                            });
                        }
                    }

                    bool firstChild = true;
                    foreach (var child in ((Extend.BlockGroup)block).Items)
                    {
                        blockType = App.Blocks.GetByType(child.Type);

                        group.Items.Add(new BlockItemModel
                        {
                            IsActive = firstChild,
                            Model = child,
                            Meta = new BlockMeta
                            {
                                Name = blockType.Name,
                                Title = child.GetTitle(),
                                Icon = blockType.Icon,
                                Component = blockType.Component
                            }
                        });
                        firstChild = false;
                    }
                    model.Blocks.Add(group);
                }
                else
                {
                    model.Blocks.Add(new BlockItemModel
                    {
                        Model = block,
                        Meta = new BlockMeta
                        {
                            Name = blockType.Name,
                            Title = block.GetTitle(),
                            Icon = blockType.Icon,
                            Component = blockType.Component
                        }
                    });
                }
            }

            // Custom editors
            foreach (var editor in type.CustomEditors)
            {
                model.Editors.Add(new EditorModel
                {
                    Component = editor.Component,
                    Icon = editor.Icon,
                    Name = editor.Title
                });
            }
            return model;
        }

        private string GetState(DynamicPage page, bool isDraft)
        {
            if (page.Created != DateTime.MinValue)
            {
                if (page.Published.HasValue)
                {
                    if (isDraft)
                    {
                        return ContentState.Draft;
                    }
                    return ContentState.Published;
                }
                else
                {
                    return ContentState.Unpublished;
                }
            }
            return ContentState.New;
        }
    }
}