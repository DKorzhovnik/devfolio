using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gtbweb.Models;
using gtbweb.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
namespace gtbweb.Controllers
{
    public class VideoController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private IDatabaseService  _dataservice;
        
        public VideoController(IDatabaseService  dataservice,UserManager<IdentityUser> userManager,
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
    
        public IActionResult Video()
        {        
                 if (_signInManager.IsSignedIn(User))
                 {
                           var videos =  _dataservice.GetVideos(_userManager.GetUserId(User));
                           ViewBag.VideoCollection = videos; 
                 }
                 

            
                
                return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
