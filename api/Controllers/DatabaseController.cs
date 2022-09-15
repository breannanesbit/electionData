using electionData.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace electionData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly InstantRunoffContext instantRunoffContext;

        public DatabaseController(InstantRunoffContext instantRunoffContext)
        {
            this.instantRunoffContext = instantRunoffContext;
        }
        [HttpGet("[action]")]
        public async Task<int> RowCount()
        {
            //get number of rows in a table
            var rowCount = await instantRunoffContext.Counties.CountAsync();
            return rowCount;
        }
    }
}
