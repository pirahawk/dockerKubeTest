using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyTestService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InformationController : ControllerBase
    {
        [HttpGet]
        [Route("time")]
        public async Task<ActionResult> GetTime(){
            var currentTime =DateTimeOffset.UtcNow;
            return Ok(new{
                CurrentTime = currentTime
            });
        }
    }
}