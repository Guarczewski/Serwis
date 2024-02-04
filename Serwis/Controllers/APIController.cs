using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serwis.Models;

namespace Serwis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        ServiceContext serviceContext;
        public APIController(ServiceContext serviceContext) {
            this.serviceContext = serviceContext;
        }

        [HttpGet("Example")] 
        public IActionResult Get()
        {
            return Ok("Success");
        }
    }
}
