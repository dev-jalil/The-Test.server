using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace TheTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ApiController
    {
        [Authorize]
        public ActionResult Get()
        {
            return Ok("Works");
        }
       
    }
}
