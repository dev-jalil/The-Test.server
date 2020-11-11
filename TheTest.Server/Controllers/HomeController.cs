using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace TheTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [Authorize]
        public IActionResult Get()
        {
            return Ok("Works");
        }
       
    }
}
