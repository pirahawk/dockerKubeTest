using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace MyTestService.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class HealthController : ControllerBase
    {
        private readonly IOptions<MyServiceConfiguration> _myServiceConfig;

        public HealthController(IOptions<MyServiceConfiguration> myServiceConfig)
        {
            _myServiceConfig = myServiceConfig;
        }

        [HttpGet]
        public async Task<ActionResult> Ping()
        {
            var message = _myServiceConfig?.Value?.Message ?? "no configuration found";
            return Ok(message);
        }
    }
}