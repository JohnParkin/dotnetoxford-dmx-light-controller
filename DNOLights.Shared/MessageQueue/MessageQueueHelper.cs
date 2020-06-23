using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace DNOLights.Shared.MessageQueue
{
    public class MessageQueueHelper : IMessageQueueHelper
    {
        private readonly QueueClient _queueClient;

        public MessageQueueHelper(Settings settings, string queueName) =>
            _queueClient = new QueueClient(settings.AzureServiceBusConnectionString, queueName);

        public async Task SendMessageAsync(string msg)
        {
            try
            {
                var message = new Message(Encoding.UTF8.GetBytes(msg));

                Console.WriteLine($"Sending message: {msg}");

                await _queueClient.SendAsync(message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{DateTime.Now} :: Exception: {exception.Message}");
            }
            finally
            {
                await _queueClient.CloseAsync();
            }
        }

        public void SubscribeAsync(Action<string> callback) =>
            _queueClient.RegisterMessageHandler(async (message, token) =>
            {
                callback(Encoding.UTF8.GetString(message.Body));
                await _queueClient.CompleteAsync(message.SystemProperties.LockToken);
            }, new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            });

        private Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            Console.WriteLine($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            Console.WriteLine("Exception context for troubleshooting:");
            Console.WriteLine($"- Endpoint: {context.Endpoint}");
            Console.WriteLine($"- Entity Path: {context.EntityPath}");
            Console.WriteLine($"- Executing Action: {context.Action}");
            return Task.CompletedTask;
        }
    }
}