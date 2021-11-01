using EasyNetQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.MqDemo
{
    public class MessageQueueReceiverDemo
    {

        private static string connStr = "host=192.168.125.77;virtualHost=MqTest;username=admin;password=admin";

        public static void Receive()
        {
            using (var bus = RabbitHutch.CreateBus(connStr))
            {
                bus.PubSub.Subscribe<MqTestMessage>("just_test_receive", HandleTextMessage);
                Console.ReadLine();
            }
        }
        public static void ReceiveEntity()
        {
            using (var bus = RabbitHutch.CreateBus(connStr))
            {
                bus.PubSub.SubscribeAsync<List<MqEntityDemo>>("test_entity_receive", HandleEntityMessage);
                Console.ReadLine();
            }
        }

       
        public static void HandleTextMessage(MqTestMessage textMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Got message: {0}", textMessage.Message);
            Console.ResetColor();
        }

        public static void HandleEntityMessage(List<MqEntityDemo> mqEntityDemos)
        {
            if (mqEntityDemos.Any(i=>i.Id=="123456789"))
            {
                Console.WriteLine("Got message: {0}", JsonConvert.SerializeObject(mqEntityDemos.First(i=>i.Id=="123456789")));
            }
            Console.ResetColor();
        }
       
    }
}
