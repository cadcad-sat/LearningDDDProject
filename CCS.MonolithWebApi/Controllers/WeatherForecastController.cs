using System.Threading.Tasks;
using CCS.MonolithWebApi.Applications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CCS.MonolithWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastService _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.List();
            return Ok(result);
        }
    }
}
