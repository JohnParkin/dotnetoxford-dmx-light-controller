using System;
using DNOLights.HardwareLib;
using DNOLights.Shared;
using DNOLights.Shared.MessageQueue;
using DNOLights.Shared.Models;
using Newtonsoft.Json;
using Con = System.Console;

namespace DNOLights.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new Settings
            {
                AzureServiceBusConnectionString = Environment.GetEnvironmentVariable("DNOLights__AzureServiceBusConnectionString")
            };

            try
            {
                OpenDMX.start(); // Find and connect to device (first found if multiple)

                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    System.Console.WriteLine("No DMX Device");
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                    System.Console.WriteLine("DMX Connected");
                else
                    System.Console.WriteLine("DMX Error");
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp);
                System.Console.WriteLine("USB Error");
            }

            new MessageQueueHelper(settings, Queues.HardwareCommands)
                    .SubscribeAsync(msg => {
                var sliderData = JsonConvert.DeserializeObject<SliderData>(msg);

                switch (sliderData.Type)
                {
                    case "Pan":
                        Con.WriteLine($"setting pan to {sliderData.Value}");
                        OpenDMX.setDmxValue(1, (byte) sliderData.Value);
                        break;
                    case "Tilt":
                        Con.WriteLine($"setting tilt to {sliderData.Value}");
                        OpenDMX.setDmxValue(3, (byte) sliderData.Value);
                        break;
                    default:
                        Con.WriteLine($"Unhandled slider type: {sliderData.Type}");
                        break;
                }
            });

            System.Console.WriteLine("Waiting for messages...");
            System.Console.ReadLine();
        }
    }
}
