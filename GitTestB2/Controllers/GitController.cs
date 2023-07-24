using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GitTestB2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitController : ControllerBase
    {
        // GET: api/<GitController>
        [HttpGet]
        public double Get()
        {
            return 7.0;
        }

        // GET api/<GitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
