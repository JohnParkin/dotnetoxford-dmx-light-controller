namespace DNOLights.Shared.MessageQueue
{
    public class MessageQueueHelperFactory : IMessageQueueHelperFactory
    {
        private readonly Settings _settings;

        public MessageQueueHelperFactory(Settings settings) =>
            _settings = settings;

        public IMessageQueueHelper Create(string queueName) =>
            new MessageQueueHelper(_settings, queueName);
    }
}