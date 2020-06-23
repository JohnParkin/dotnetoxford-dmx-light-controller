using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace DNOLights.API
{
    public class BackgroundProcessor : BackgroundService
    {
        private readonly QueueLogic _queueLogic;

        public BackgroundProcessor(QueueLogic queueLogic) =>
            _queueLogic = queueLogic;

        protected override async Task ExecuteAsync(CancellationToken cancellationToken) =>
            await _queueLogic.MainMessageLoopAsync(cancellationToken);
    }
}