using System;
using System.Threading;
using System.Threading.Tasks;
using DNOLights.API.Users;
using DNOLights.Shared;
using DNOLights.Shared.MessageQueue;
using Microsoft.Extensions.Logging;

namespace DNOLights.API
{
    public class QueueLogic
    {
        private readonly IUserQueue _userQueue;
        private readonly ILogger<QueueLogic> _logger;
        private readonly IMessageQueueHelperFactory _messageQueueHelperFactory;
        private User _userInControl;

        public QueueLogic(IUserQueue userQueue, ILogger<QueueLogic> logger, IMessageQueueHelperFactory messageQueueHelperFactory)
        {
            _userQueue = userQueue;
            _logger = logger;
            _messageQueueHelperFactory = messageQueueHelperFactory;
        }

        public async Task MainMessageLoopAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var nextUser = _userQueue.PopUserFromQueue();

                if (nextUser != null)
                {
                    _userInControl = nextUser;
                    await NotifyDashboardAboutChangeInQueueAsync(cancellationToken);
                    await NotifyDashboardAboutNewUserInControlAsync(nextUser.UserName, cancellationToken);
                    _logger.LogInformation("Giving control to {0}", _userInControl.UserName);
                    await Task.Delay(TimeSpan.FromSeconds(30), cancellationToken);
                    _logger.LogInformation("End of user {0}'s time period", _userInControl.UserName);
                }

                await Task.Delay(TimeSpan.FromMilliseconds(20), cancellationToken);
            }
        }

        public async Task<Guid> AddUserToQueueAsync(string username, CancellationToken cancellationToken)
        {
            var userId = Guid.NewGuid();

            _logger.LogInformation($"Adding user {username} to the queue");
            _userQueue.PushUserToQueue(userId, username);

            await NotifyDashboardAboutChangeInQueueAsync(cancellationToken);

            return userId;
        }

        public bool DoesUserHaveControl(Guid userId) =>
            _userInControl?.UserId == userId;

        private async Task NotifyDashboardAboutChangeInQueueAsync(CancellationToken cancellationToken) =>
            await _messageQueueHelperFactory.Create(Queues.UserQueueChange)
                .SendMessageAsync("");

        private async Task NotifyDashboardAboutNewUserInControlAsync(string username, CancellationToken cancellationToken) =>
            await _messageQueueHelperFactory.Create(Queues.NewUserInControl)
                .SendMessageAsync(username);
    }
}