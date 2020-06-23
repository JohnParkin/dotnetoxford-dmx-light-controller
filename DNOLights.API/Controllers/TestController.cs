using System.Threading.Tasks;
using DNOLights.Shared.MessageQueue;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DNOLights.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly IMessageQueueHelper _messageQueueHelper;

        public TestController(ILogger<TestController> logger, IMessageQueueHelper messageQueueHelper)
        {
            _logger = logger;
            _messageQueueHelper = messageQueueHelper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            await _messageQueueHelper.SendMessageAsync("Test message");
            return Ok();
        }
    }
}
