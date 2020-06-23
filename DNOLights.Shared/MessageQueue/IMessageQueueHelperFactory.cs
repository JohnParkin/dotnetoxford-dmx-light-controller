namespace DNOLights.Shared.MessageQueue
{
    public interface IMessageQueueHelperFactory
    {
        IMessageQueueHelper Create(string queueName);
    }
}