using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gtbweb.Models;
using gtbweb.Services;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace gtbweb.Controllers
{
    public class InputPageModel
    {
             [BindProperty]
              public string Editor{get;set;}
             [BindProperty]
              public string Pageid{get;set;}
    }
    public class PageController : Controller
    {   private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private IDatabaseService  _dataservice;
        
         public PageController(IDatabaseService  dataservice,UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
               _dataservice = dataservice; 
               _userManager = userManager;
               _signInManager = signInManager;
                   
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page(int? id)
        {
            var page =  _dataservice.GetBlogPage(id);
                ViewBag.PageDetails = page; 
              
            return View();
        }
        public IActionResult Save(InputPageModel Input)
        {
            _dataservice.SaveBlogText(Input.Editor,Input.Pageid);
                
            return LocalRedirect(Url.Content("~/Page/Page/"+Input.Pageid));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
