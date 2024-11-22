using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VueApp4.Server.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            // 返回一个简单的消息
            return Ok("Hello from ASP.NET Core!");
        }
    }
}
