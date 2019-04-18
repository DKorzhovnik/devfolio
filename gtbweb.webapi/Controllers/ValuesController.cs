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
    public class ValuesController : ControllerBase
    {
        private IDatabaseService _dataservice;
        public ValuesController(IDatabaseService dataservice)
        {
              _dataservice= dataservice;      
        }

        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
             var pi =  _dataservice.GetProfile(7);

            return new string[] { pi.Designation, pi.About };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
