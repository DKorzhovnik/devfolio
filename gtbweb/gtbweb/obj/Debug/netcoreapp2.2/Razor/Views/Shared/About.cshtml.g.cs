#pragma checksum "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4395607fa1c63f3e79e11e47d8f0397a6ac9c86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_About), @"mvc.1.0.view", @"/Views/Shared/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/About.cshtml", typeof(AspNetCore.Views_Shared_About))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/_ViewImports.cshtml"
using gtbweb;

#line default
#line hidden
#line 2 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/_ViewImports.cshtml"
using gtbweb.Models;

#line default
#line hidden
#line 6 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4395607fa1c63f3e79e11e47d8f0397a6ac9c86", @"/Views/Shared/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ea669bc11d581dd473ff14b2dcc1ac5ada8731", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gtbweb.Controllers.InputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control input-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveAbout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveDesignation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveProficiency", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral(" \n");
            EndContext();
            BeginContext(40, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 3 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
   
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(116, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(213, 407, true);
            WriteLiteral(@"
  <section id=""about"" class=""about-mf sect-pt4 route"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-sm-12"">
          <div class=""box-shadow-full"">
            <div class=""row"">
              <div class=""col-md-6"">
                <div class=""row"">
                  <div class=""col-sm-6 col-md-5"">
                    <div class=""about-img"">
                      <img src= ");
            EndContext();
            BeginContext(621, 28, false);
#line 21 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
                           Write(ViewBag.ProfileDetails.Image);

#line default
#line hidden
            EndContext();
            BeginContext(649, 267, true);
            WriteLiteral(@" class=""img-fluid b-shadow-a rounded-circle"" alt="""">
                    </div>
                  </div>
                  <div class=""col-sm-6 col-md-7"">
                    <div class=""about-info"">
                      <p><span class=""title-s"">Name: </span> <span>");
            EndContext();
            BeginContext(917, 34, false);
#line 26 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
                                                              Write(ViewBag.ProfileDetails.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(951, 83, true);
            WriteLiteral(" </span></p>\n                      <p><span class=\"title-s\">Profile: </span> <span>");
            EndContext();
            BeginContext(1035, 34, false);
#line 27 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
                                                                 Write(ViewBag.ProfileDetails.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 231, true);
            WriteLiteral("</span><a href=\"#DesignationForm\" data-backdrop=\"false\" data-toggle=\"modal\" data-target=\"#DesignationForm\"><span class=\"glyphicon glyphicon-pencil\"></span></a><p>\n                      <p><span class=\"title-s\">Email: </span> <span>");
            EndContext();
            BeginContext(1301, 18, false);
#line 28 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
                                                               Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 565, true);
            WriteLiteral(@"</span></p>
                    </div>
                  </div>
                </div>
                <div class=""skill-mf"">
                 <div class=""title-s"">
                   <div class=""row"">
                     <div class=""col-sm-3"">
                     <p class=""title-s"">Skill</p>
                     </div>
                     <div class=""col-sm-3"">
                     <a  href=""#SkillForm"" data-backdrop=""false"" data-toggle=""modal"" data-target=""#SkillForm"">Add</a>
                     </div>
                  </div>
                   </div>
");
            EndContext();
#line 43 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
  foreach(var x in @ViewBag.ProficiencyList)
      {

#line default
#line hidden
            BeginContext(1937, 24, true);
            WriteLiteral("                  <span>");
            EndContext();
            BeginContext(1962, 7, false);
#line 45 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
                   Write(x.Skill);

#line default
#line hidden
            EndContext();
            BeginContext(1969, 33, true);
            WriteLiteral("</span> <span class=\"pull-right\">");
            EndContext();
            BeginContext(2003, 7, false);
#line 45 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
                                                            Write(x.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2010, 114, true);
            WriteLiteral("%</span>\n                  <div class=\"progress\">\n                    <div class=\"progress-bar\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2124, "\"", 2149, 3);
            WriteAttributeValue("", 2132, "width:", 2132, 6, true);
#line 47 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
WriteAttributeValue(" ", 2138, x.Score, 2139, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2147, "%;", 2147, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=", 2150, "", 2173, 1);
#line 47 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
WriteAttributeValue("", 2165, x.Score, 2165, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2173, 93, true);
            WriteLiteral(" aria-valuemin=\"0\"\n                      aria-valuemax=\"100\"></div>\n                  </div>\n");
            EndContext();
#line 50 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
      }

#line default
#line hidden
            BeginContext(2274, 378, true);
            WriteLiteral(@"
                </div>
              </div>
              <div class=""col-md-6"">
                <div class=""about-me pt-4 pt-md-0"">
                  <div class=""title-box-2"">
                    <h5 class=""title-left"">
                      About me
                    </h5>
                  </div>
                  
                  <p class=""lead"">
                    ");
            EndContext();
            BeginContext(2653, 28, false);
#line 63 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
               Write(ViewBag.ProfileDetails.About);

#line default
#line hidden
            EndContext();
            BeginContext(2681, 1900, true);
            WriteLiteral(@"
                  </p>
                  <div class=""edit-panel"">
                 <textarea  name=""content"" id=""editor"">This is some sample content.</textarea>
                <script>
                        ClassicEditor
                                .create( document.querySelector( '#editor' ) )
                                
                                .catch( error => {
                                        console.error( error );
                                } );
                </script>
                </div>
                </div>
                <button id=""edit-panel-trigger""type=""button"" class=""btn btn-primary"" data-backdrop=""false"" data-toggle=""modal"" data-target=""#basicModal"">Edit</button>

                  <!-- The Modal -->

                  
	<div class=""modal fade"" id=""basicModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""basicModal"" aria-hidden=""true"">
		<div class=""modal-dialog modal-lg"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<button type=""b");
            WriteLiteral(@"utton"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
				</div>
				<div class=""modal-body"">
					<div id=""editor"">
						<p>This is sample content of <a href=""https://ckeditor.com"">CKEditor 5 Balloon Build</a>.</p>

						<p>Now, <strong>make some text selection</strong>! :)</p>

					</div>
				</div>
			</div>
		</div>
	</div>

                  <div id=""ModalLoginForm"" class=""modal fade"" >
                      <div class=""modal-dialog"" role=""document"">
                          <div class=""modal-content"">
                              <div class=""modal-header"">
                                  <h1 class=""modal-title"">Edit</h1>
                              </div>
                              <div class=""modal-body"">
                               
                                  ");
            EndContext();
            BeginContext(4581, 1226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8615238", async() => {
                BeginContext(4648, 327, true);
                WriteLiteral(@"
                                      <input type=""hidden"" name=""_token"" value="""">
                                      <div class=""form-group"">
                                          <label class=""control-label"">About</label>
                                          <div >
                                              ");
                EndContext();
                BeginContext(4975, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8615953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 115 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.About);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5065, 735, true);
                WriteLiteral(@"
                                          </div>
                                      </div>
                                      <div class=""form-group"">
                                          <div>
                                              <button type=""submit"" class=""btn btn-success"">
                                                  Save
                                              </button>
                                              <button type=""button"" class=""btn btn-default pull-right btn-danger"" data-dismiss=""modal"">Close</button>
                                          </div>
                                        </div>
                                      </div>
                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5807, 623, true);
            WriteLiteral(@"
                              </div>
                          </div><!-- /.modal-content -->
                      </div><!-- /.modal-dialog -->
                  </div><!-- /.modal -->
                  <div id=""DesignationForm"" class=""modal fade"" >
                      <div class=""modal-dialog"" role=""document"">
                          <div class=""modal-content"">
                              <div class=""modal-header"">
                                  <h1 class=""modal-title"">Edit</h1>
                              </div>
                              <div class=""modal-body"">
                                  ");
            EndContext();
            BeginContext(6430, 1237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8621027", async() => {
                BeginContext(6503, 332, true);
                WriteLiteral(@"
                                      <input type=""hidden"" name=""_token"" value="""">
                                      <div class=""form-group"">
                                          <label class=""control-label"">Designation</label>
                                          <div>
                                              ");
                EndContext();
                BeginContext(6835, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8621747", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 144 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Designation);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6929, 731, true);
                WriteLiteral(@"
                                          </div>
                                      </div>
                                      <div class=""form-group"">
                                          <div>
                                              <button type=""submit"" class=""btn btn-success"">
                                                  Save
                                              </button>
                                              <button type=""button"" class=""btn btn-default pull-right btn-danger"" data-dismiss=""modal"">Close</button>
                                          </div>
                                          
                                      </div>
                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7667, 621, true);
            WriteLiteral(@"
                              </div>
                          </div><!-- /.modal-content -->
                      </div><!-- /.modal-dialog -->
                  </div><!-- /.modal -->
                  <div id=""SkillForm"" class=""modal fade""  > 
                      <div class=""modal-dialog"" role=""document"">
                          <div class=""modal-content"">
                              <div class=""modal-header"">
                                  <h1 class=""modal-title"">Skills</h1>
                              </div>
                              <div class=""modal-body"">
                                  ");
            EndContext();
            BeginContext(8288, 2315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8626821", async() => {
                BeginContext(8361, 1099, true);
                WriteLiteral(@"
                                      <input type=""hidden"" name=""_token"" value="""">
                                      <div class=""form-group"">
                                          
                                          
                                          <div class=""row"">
                                            
                                              <div class=""col-md-5"">
                                                  <label class=""control-label"">Add a Skill</label>
                                              </div>
                                                <div class=""col-md-6"">
                                                   <label class=""control-label"">Add a Score</label>
                                              </div>
                                         
                                          </div>
                                          <div class=""row"">
                                            
                                             ");
                WriteLiteral(" <div class=\"col-md-5\">\n                                                   ");
                EndContext();
                BeginContext(9460, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8628356", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 186 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Skill);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 186 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SkillList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9554, 176, true);
                WriteLiteral("\n                                              </div>\n                                                <div class=\"col-md-6\">\n                                                   ");
                EndContext();
                BeginContext(9730, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4395607fa1c63f3e79e11e47d8f0397a6ac9c8630616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 189 "/mnt/c/users/olukowi/gtbweb/gtbweb/gtbweb/Views/Shared/About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Score);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9814, 782, true);
                WriteLiteral(@"
                                              </div>
                                         
                                          </div>
                                     </div>
                                      <div class=""form-group"">
                                          <div>
                                              <button type=""submit"" class=""btn btn-success"">
                                                  Save
                                              </button>
                                              <button type=""button"" class=""btn btn-default pull-right btn-danger"" data-dismiss=""modal"">Close</button>
                                          </div>
                                      </div>
                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10603, 296, true);
            WriteLiteral(@"
                              </div>
                          </div><!-- /.modal-content -->
                      </div><!-- /.modal-dialog -->
                  </div><!-- /.modal -->
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gtbweb.Controllers.InputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591