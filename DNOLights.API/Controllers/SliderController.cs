using System.Threading.Tasks;
using DNOLights.API.Models;
using DNOLights.API.Users;
using DNOLights.Shared;
using DNOLights.Shared.MessageQueue;
using DNOLights.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DNOLights.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SliderController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly QueueLogic _queueLogic;
        private readonly IMessageQueueHelper _messageQueueHelper;

        public SliderController(ILogger<TestController> logger, IMessageQueueHelperFactory messageQueueHelperFactory, QueueLogic queueLogic)
        {
            _logger = logger;
            _queueLogic = queueLogic;
            _messageQueueHelper = messageQueueHelperFactory.Create(Queues.HardwareCommands);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SliderRequest requestData)
        {
            if (!_queueLogic.DoesUserHaveControl(requestData.UserId))
                return Conflict();

            await _messageQueueHelper.SendMessageAsync(JsonConvert.SerializeObject(new SliderData {
                Type = requestData.SliderType,
                Value = requestData.Value
            }));

            return Ok();
        }
    }
}
