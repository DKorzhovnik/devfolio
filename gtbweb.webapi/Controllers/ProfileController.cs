using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gtbweb.Models;
using gtbweb.Services;

namespace gtbweb.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IDatabaseService _dataservice;
        public ProfileController(IDatabaseService dataservice)
        {
              _dataservice= dataservice;      
        }

        
        // GET api/profile
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
             var pi =  _dataservice.GetSkills();

           // return new string[] { pi.Designation, pi.About };
            return new string[] {" pi.Designation", "pi.About" };
        }

        // GET api/profile/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/profile
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/profile/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/profile/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
