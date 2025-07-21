using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MySwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // 🔐 Requires valid JWT token with "Admin" role
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Get()
        {
            var employees = new[] { "John", "Alice", "Bob" };
            return Ok(employees);
        }

        // 🌐 Open to all (anonymous access)
        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult PublicAccess()
        {
            return Ok("This is a public endpoint.");
        }
    }
}
