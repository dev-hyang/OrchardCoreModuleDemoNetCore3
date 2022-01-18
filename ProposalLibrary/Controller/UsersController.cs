using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProposalLibrary.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Test()
        {
            return Ok();
        }
    }
}
