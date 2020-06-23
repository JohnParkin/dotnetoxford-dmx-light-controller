using DNOLights.API.Users;
using Microsoft.AspNetCore.Mvc;

namespace DNOLights.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    {
        private readonly IUserQueue _userQueue;

        public QueueController(IUserQueue userQueue) =>
            _userQueue = userQueue;

        [HttpGet]
        public IActionResult Get() =>
            Ok(_userQueue.GetAllUsersFromQueue());
    }
}
