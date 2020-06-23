using System;
using Microsoft.AspNetCore.Mvc;

namespace DNOLights.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AmIInControlController : ControllerBase
    {
        private readonly QueueLogic _queueLogic;

        public AmIInControlController(QueueLogic queueLogic) =>
            _queueLogic = queueLogic;

        [HttpGet("{userId}")]
        public IActionResult Get(Guid userId) =>
            Ok(_queueLogic.DoesUserHaveControl(userId) ? "yes" : "no");
    }
}
