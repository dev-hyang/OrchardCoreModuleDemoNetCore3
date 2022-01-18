using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("wo")]
    public class WorkOrderController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task GetAsync()
        {
            //Option1, call Repository Library Or manager to Get
            //Option2, use graphql
        }

        [HttpPost]
        public async Task PostAsync([FromBody] CreateWoModel woModel)
        {
            //Option1, call Repository Library to insert
            //Option2, Create commands and use domain event to create wo
        }

        [HttpPut]
        public async Task PutAsync([FromBody] CreateWoModel woModel)
        {
            //Option1, call Repository Library to update
            //Option2, Create commands and use domain event to update wo
        }
    }
}
