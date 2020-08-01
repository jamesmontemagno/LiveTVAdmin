using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveTVAdmin.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiveTVAdmin.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ShowController : ControllerBase
    {
        static List<Show> Shows = new List<Show>
        {
            new Show{Id = "learn-csharp",
            Name = "Learn C# with CSharpFritz",
            Description ="Every week come and learn C# with Jeff Fritz (CSharpFritz) and learn to build apps for web, mobile, desktop, and more.",
            Url ="https://twitch.tv/VisualStudio"}
        };
        // GET: api/<ShowController>
        [HttpGet]
        public IEnumerable<Show> Get()
        {
            return Shows;
        }

        // GET api/<ShowController>/5
        [HttpGet("{id}")]
        public Show Get(string id)
        {
            return Shows.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<ShowController>
        [HttpPost]
        public void Post([FromBody] Show value)
        {
            Shows.Add(value);
        }

        // PUT api/<ShowController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Show value)
        {
            Delete(id);
            Post(value);
        }

        // DELETE api/<ShowController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Shows.Remove(Shows.First(x => x.Id == id));
        }
    }
}
