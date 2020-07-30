using Microsoft.AspNetCore.Mvc;

namespace BasicWebProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() => "It Works!";
    }
}