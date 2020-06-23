using System.Threading;
using System.Threading.Tasks;
using DNOLights.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNOLights.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly QueueLogic _queueLogic;

        public RegisterController(QueueLogic queueLogic) =>
            _queueLogic = queueLogic;

        [HttpPost]
        public async Task<IActionResult> Post(RegisterPostRequest requestData, CancellationToken cancellationToken) =>
            Ok(await _queueLogic.AddUserToQueueAsync(requestData.Username, cancellationToken));
    }
}
