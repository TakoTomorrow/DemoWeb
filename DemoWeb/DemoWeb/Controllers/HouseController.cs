using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {        
        // GET api/<HouseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HouseController>
        [HttpPost]
        public void Create([FromBody] string value)
        {
        }

        // PUT api/<HouseController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
