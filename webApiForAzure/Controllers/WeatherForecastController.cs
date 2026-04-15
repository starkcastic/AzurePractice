using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        // Default API (already exists)
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "API is running 🚀" });
        }

        // ✅ Your custom API
        [HttpGet("user")]
        public IActionResult GetUser()
        {
            return Ok(new { name = "Virat Kohli", role = "Batsman" });
        }

        // ✅ POST API (bonus)
        [HttpPost("data")]
        public IActionResult PostData([FromBody] object data)
        {
            return Ok(new { message = "Received", data });
        }
    }
}