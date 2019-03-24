using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gtbweb.Models;


namespace gtbweb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
 

        //you can search database with person id 
        Profile p = new Profile();
        p.Designation = "FirstName";
        p.Image= "/img/testimonial-2.jpg";
        p.RegistrationDate =  DateTime.Parse("2005-09-01");
        p.UserID=125;
        p.About="hhjhjhjh";

       // Dictionary<string, string> profileDetails = new Dictionary<string, string>();
        

      //  foreach (PropertyInfo prop in p.GetType().GetProperties())
        //{

          //  var propName = prop.Name;
            //var propValue = prop.GetValue(p, null);
            //profileDetails.Add(propName.ToString(),propValue.ToString());

        //}
        ViewBag.profileDetails = p; 
        //profileDetails;
    
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
