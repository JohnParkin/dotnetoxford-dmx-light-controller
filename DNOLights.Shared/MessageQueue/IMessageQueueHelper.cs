using System;
using System.Threading.Tasks;

namespace DNOLights.Shared.MessageQueue
{
    public interface IMessageQueueHelper
    {
        Task SendMessageAsync(string msg);
        void SubscribeAsync(Action<string> callback);
    }
}