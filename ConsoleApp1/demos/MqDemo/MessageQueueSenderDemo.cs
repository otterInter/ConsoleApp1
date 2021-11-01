using EasyNetQ;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.MqDemo
{
    public class MessageQueueSenderDemo
    {
        private static string connStr = "host=192.168.125.77;virtualHost=MqTest;username=admin;password=admin";
        public static void Send(string sendStr, MqEntityDemo mqEntityDemo)
        {
            using (var bus = RabbitHutch.CreateBus(connStr))
            {

                bus.PubSub.PublishAsync(new MqTestMessage
                {
                    Message = sendStr
                });

                Console.WriteLine(sendStr);

                Console.ReadLine();
            }
        }
        
        public static void SendEntity(List<MqEntityDemo> mqEntityDemos)
        {
            using (var bus = RabbitHutch.CreateBus(connStr))
            {

                bus.PubSub.Publish(mqEntityDemos);


                Console.ReadLine();
            }
        }
    }
}
