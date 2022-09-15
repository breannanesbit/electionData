using electionData.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace electionData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BallotsController : ControllerBase
    {
        private readonly InstantRunoffContext instantRunoffContext;

        public BallotsController(InstantRunoffContext instantRunoffContext)
        {
            this.instantRunoffContext = instantRunoffContext;
        }
        // GET: api/<ValuesControllr>
        [HttpGet]
        public IEnumerable<string> GetBallots()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string GetBallots(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void PostBallots([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void PutBallots(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void DeleteBallots(int id)
        {
        }
    }
}
