using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BotZeitNot.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly ILogger<UpdateController> _logger;


        public UpdateController(ILogger<UpdateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "kek";
        }

        [HttpPost]
        public IActionResult Post()
        {

            return Ok();
        }
    }
}