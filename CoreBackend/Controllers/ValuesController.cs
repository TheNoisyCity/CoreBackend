using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreBackend.Models;

namespace CoreBackend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly MySqlContext _context;

        public ValuesController(MySqlContext context){
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id, [FromBody]Like value)
        {
            return value.Rid.ToString();
        }

        // POST api/values
        [HttpPost]
        public String Post(Like value)
        {
            _context.Like.Add(value);
            _context.SaveChanges();;
            return value.Rid.ToString();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Like value)
        {
            return value.Rid.ToString();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
