using Microsoft.AspNetCore.Mvc;

namespace Web_API_ConfigDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ConfigController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult GetAppSettings()
        {
            var appName = _config["AppSettings:ApplicationName"];
            var version = _config["AppSettings:Version"];

            return Ok(new { appName, version });
        }
    }
}
