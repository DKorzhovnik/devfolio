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
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace gtbweb.Controllers
{
            
          public class InputModel
             {
              [BindProperty]
              public string About {get;set;}
   
             }
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private IDatabaseService  _dataservice;
        
        
       
        public AboutController(IDatabaseService  dataservice,UserManager<IdentityUser> userManager,
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
         
     
        public async Task<IActionResult> About()
        {
                  
                var profile =  _dataservice.GetProfile(_userManager.GetUserId(User));
                ViewBag.ProfileDetails = profile; 
                
                    return View();
        }

       
        public async Task<IActionResult>  Save(InputModel input)
        {
             
                  _dataservice.SaveAbout(input.About,_userManager.GetUserId(User));        
             return LocalRedirect(Url.Content("~/About/About"));
        }
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
