using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "✅ Hello from Values Controller!";
        }
    }
}
