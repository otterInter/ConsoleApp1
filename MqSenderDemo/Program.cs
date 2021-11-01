using ConsoleApp1.demos.MqDemo;
using EasyNetQ;
using System;
using System.Collections.Generic;

namespace MqSenderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Send Begin");

            var entities = new List<MqEntityDemo>() {
                new MqEntityDemo("00000", "张三", 0),
                new MqEntityDemo("123456789", "李四", 0)
            };
            MessageQueueSenderDemo.SendEntity(entities);
        }
    }
}
