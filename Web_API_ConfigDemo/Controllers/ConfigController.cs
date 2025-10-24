using Microsoft.AspNetCore.Mvc;

namespace Web_API_ConfigDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ConfigController(IConfiguration config)
        {
            _configuration = config;
        }

        [HttpGet]
        public IActionResult GetAppSettings()
        {
            var appName = _configuration["AppSettings:ApplicationName"];
            var version = _configuration["AppSettings:Version"];
            var maxItems = _configuration["AppSettings:MaxItems"];

            return Ok(new
            {
                ApplicationName = appName,
                Version = version,
                MaxItems = maxItems
            });
        }
    }
}
