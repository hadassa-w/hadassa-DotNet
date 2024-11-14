using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Servies
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookServies : ControllerBase
    {
        // GET: api/<BookServies>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookServies>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookServies>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookServies>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookServies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
