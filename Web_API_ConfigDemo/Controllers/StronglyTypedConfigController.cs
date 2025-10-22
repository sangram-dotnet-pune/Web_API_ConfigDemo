using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Web_API_ConfigDemo.Models;

namespace Web_API_ConfigDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StronglyTypedConfigController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        // Constructor injection of IOptions<AppSettings>
        public StronglyTypedConfigController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult GetConfig()
        {
            return Ok(new
            {
                ApplicationName = _appSettings.ApplicationName,
                Version = _appSettings.Version,
                Author = _appSettings.Author
            });
        }
    }
}
