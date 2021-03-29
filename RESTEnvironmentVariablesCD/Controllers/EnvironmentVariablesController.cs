using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTEnvironmentVariablesCD.Managers;
using RESTEnvironmentVariablesCD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTEnvironmentVariablesCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentVariablesController : ControllerBase
    {
        private readonly EnvironmentVariablesManager _manager = new EnvironmentVariablesManager();

        // GET: api/<EnvironmentVariablesController>
        [HttpGet]
        public IEnumerable<EnvironmentVariable> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<EnvironmentVariablesController>/5
        [HttpGet("{name}")]
        public EnvironmentVariable Get(string name)
        {
            return _manager.GetByName(name);
        }

        // POST api/<EnvironmentVariablesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EnvironmentVariablesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EnvironmentVariablesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
