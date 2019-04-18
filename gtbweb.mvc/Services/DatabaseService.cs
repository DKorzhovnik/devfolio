using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using gtbweb.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Linq;

namespace gtbweb.Services
{
        public interface IDatabaseService
        {
             Profile GetProfile(string id);
             ServiceCollectionViewModel GetService(string id);
             BlogCollectionViewModel GetBlogs(string id);
             BlogPageViewModel GetBlogPage(string id);
             PortfolioCollectionViewModel  GetPortfolio(string id);
        }
        public class ServiceCollectionViewModel
        {
         
           public  string   Slogan { get; set; }
           public  ICollection<ServiceViewModel>  ServiceView { get; set; }
           
        }
        public class ServiceViewModel
        {
         
           public  string   Title { get; set; }
           public  string   ServiceDescription { get; set; }
           
        }
        public class PortfolioViewModel
        {
           public  string   Title { get; set; }
           public  string   Tag { get; set; }
           public  string   PortfolioImage { get; set; }
           public  DateTime CreationDate { get; set; }
        }
         public class BlogCollectionViewModel
        {
          
           public  string   Slogan { get; set; }
           public  ICollection<BlogPageViewModel>  BlogView { get; set; }
        }
        public class PortfolioCollectionViewModel
        {
           public  string   Slogan { get; set; }
           public  int   WorksCompleted { get; set; }
           public  int   AwardsWon { get; set; }
           public  int   TotalClients { get; set; }
           public  int  YearsOfExperience { get; set; }
           public  ICollection<PortfolioViewModel>  Portfolio { get; set; }
        }
         public class BlogPageViewModel
        {  public  int      ProfileID  { get; set; }
           public  string   BlogImage  { get; set; }
           public  string   Title { get; set; }
           public  string   FullName { get; set; }
           public  string   PageTag { get; set; }
           public  int   ReadTime { get; set; }
           public  TagCollectionViewModel   TagCollection { get; set; }
           public  int   CommentCount { get; set; }
           public  string   Text { get; set; }
           //public  string  Author { get; set; }
           public  ICollection<RecentPostViewModel>  RecentPost { get; set; }
           public  ICollection<CommentViewModel>  Comments { get; set; }
        }
         public class RecentPostViewModel
         {
            public int PostID { get; set; }
            public  string   Title { get; set; }
         }
          public class ReplyViewModel
         {
            public int CommentID { get; set; }
            public  string   Text { get; set; }
            public  string   Image { get; set; }
            public  string   FullName { get; set; }
 
            public DateTime CreationDate { get; set; }

            public ICollection<CommentViewModel>  Reply{ get; set; }
         }
          public class CommentViewModel
         {
            public int CommentID { get; set; }
            public  string   Text { get; set; }
            public  string   Image { get; set; }
            public  string   FullName { get; set; }
 
            public DateTime CreationDate { get; set; }

            public ICollection<ReplyViewModel>  Reply{ get; set; }
         }
         public class TagCollectionViewModel
         {
            public int TagCollectionID { get; set; }
           public  ICollection<TagViewModel>  TagList { get; set; }
         }
         public class TagViewModel
         {
            public  string   Title { get; set; }
         }
        public class Seed
         {
            public List<RecentPostViewModel> posts { get; set; }
            public List<BlogPageViewModel> pages { get; set; }
            public BlogPageViewModel page { get; set; }
            public TagCollectionViewModel tagcollection { get; set; }
            public ICollection<CommentViewModel> commentlist { get; set; }
            public ICollection<ReplyViewModel> commentlists { get; set; }
            public ICollection<TagViewModel> taglist { get; set; }
            public BlogCollectionViewModel blogs { get; set; }
            public ServiceCollectionViewModel services { get; set; }
            public ICollection<ServiceViewModel> servicelist { get; set; }
            public PortfolioCollectionViewModel portfolios { get; set; }
            public ICollection<PortfolioViewModel> portfoliolist { get; set; }
            public Seed()
            {
                   taglist = new List<TagViewModel>
                     {
                           new TagViewModel{Title="Alex"},
                           new TagViewModel{Title="Alex"}
                     };
                    tagcollection = new TagCollectionViewModel{TagCollectionID=1,TagList=taglist };
                    posts = new List<RecentPostViewModel>
                     {
                           new RecentPostViewModel{PostID=2,Title="Alex"},
                           new RecentPostViewModel{PostID=3, Title="Alexander"}
                     };
                      commentlist = new List<CommentViewModel>
                              {
                                    new CommentViewModel{CommentID=1,Text="Alex",Image="/img/testimonial-2.jpg",FullName="Alex",CreationDate=DateTime.Parse("2005-09-01"),Reply=commentlists},
                                    new CommentViewModel{CommentID=2,Text="Alex",Image="/img/testimonial-2.jpg",FullName="Alex",CreationDate=DateTime.Parse("2005-09-01"),Reply=commentlists}
                              };
                     commentlists = new List<ReplyViewModel>
                              {
                                    new ReplyViewModel{CommentID=1,Text="Alex",Image="/img/testimonial-2.jpg",FullName="Alex",CreationDate=DateTime.Parse("2005-09-01"),Reply=null},
                                    new ReplyViewModel{CommentID=2,Text="Alex",Image="/img/testimonial-2.jpg",FullName="Alex",CreationDate=DateTime.Parse("2005-09-01"),Reply=null}
                              };
                    pages = new List<BlogPageViewModel>
                     {
                           new BlogPageViewModel{ProfileID=1,BlogImage="/img/testimonial-2.jpg",Title="Alex",FullName="Alex",PageTag="Alex",ReadTime=20,TagCollection=tagcollection,CommentCount=30,Text="FrontEnd",RecentPost=posts,Comments=commentlist},
                           new BlogPageViewModel{ProfileID=1,BlogImage="/img/testimonial-2.jpg",Title="Alex",FullName="Alex",PageTag="Alex",ReadTime=30,TagCollection=tagcollection,CommentCount=30,Text="FrontEnd",RecentPost=posts,Comments=commentlist}
                     };
                    servicelist = new List<ServiceViewModel>
                     {
                           new ServiceViewModel{Title="Web design",ServiceDescription="Artful Design is not an accident,it requires Art. "},
                           new ServiceViewModel{Title="Photography",ServiceDescription="A thousand words caught in the stillness of a flash"}
                     };
                    portfoliolist = new List<PortfolioViewModel>
                     {
                           new PortfolioViewModel{Title="Web design",Tag="Alex",PortfolioImage="/img/work-1.jpg",CreationDate=DateTime.Parse("2005-09-01")},
                           new PortfolioViewModel{Title="Web design",Tag="Alex",PortfolioImage="/img/work-2.jpg",CreationDate=DateTime.Parse("2005-09-01")}
                     };
                   page= new BlogPageViewModel{ProfileID=1,BlogImage="/img/testimonial-2.jpg",Title="Alex",FullName="Alex",PageTag="Alex",ReadTime=30,TagCollection=tagcollection,CommentCount=30,Text="Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Cras ultricies ligula sed magna dictum porta. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula. Nulla quis lorem ut libero malesuada feugiat.",RecentPost=posts,Comments=commentlist};          
                   blogs= new BlogCollectionViewModel{Slogan="Creativity Has no Limits",BlogView=pages};
                   services= new ServiceCollectionViewModel{Slogan="Creativity Has no Limits",ServiceView=servicelist};
                   portfolios= new PortfolioCollectionViewModel{Slogan="Creativity Has no Limits",WorksCompleted=20,AwardsWon=4,TotalClients=9,YearsOfExperience=12, Portfolio=portfoliolist};
            
            }
         }

        public class DatabaseService: IDatabaseService
        {
            private readonly BlogDbContext  _theContext;

            public DatabaseService(BlogDbContext _context )
            {
              
                   _theContext=_context;
                   
            }
            
             public Profile GetProfile(string id)
             {
                var profile =  _theContext.Profiles.Where(s => s.UserID == id).FirstOrDefault<Profile>();
                 return profile;
             }
             public ServiceCollectionViewModel  GetService(string id)
             {
                   IEnumerable<Proficiency> collections = _theContext.Proficiencies;
                   IEnumerable<Service> services = _theContext.Services;
                   var querys = collections.Where(s =>s.ProfileID == 1 ).FirstOrDefault<Proficiency>();
                   var query = new Seed().services;
                   return query;
             }
              public BlogCollectionViewModel GetBlogs(string id)
             {
                   IEnumerable<BlogCollection> collections = _theContext.BlogCollections;
                   IEnumerable<Service> services = _theContext.Services;
                   var querys = collections.Where(s =>s.ProfileID == 1 ).FirstOrDefault<BlogCollection>();
                   var query = new Seed().blogs;
                   return query;
             }
              public PortfolioCollectionViewModel GetPortfolio(string id)
             {
                   IEnumerable<BlogCollection> collections = _theContext.BlogCollections;
                   IEnumerable<Service> services = _theContext.Services;
                   var querys = collections.Where(s =>s.ProfileID == 1 ).FirstOrDefault<BlogCollection>();
                   var query = new Seed().portfolios;
                   return query;
             }
              public BlogPageViewModel GetBlogPage(string id)
             {
                   IEnumerable<BlogPage> collections = _theContext.BlogPages;
                   IEnumerable<Service> services = _theContext.Services;
                   var querys = collections.Where(s =>s.ProfileID == 1 ).FirstOrDefault<BlogPage>();
                   var query = new Seed().page;
                   return query;
             }
        } 
}