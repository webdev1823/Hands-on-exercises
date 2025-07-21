using Microsoft.AspNetCore.Mvc;

namespace MySwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from ValueController");
        }
    }
}
