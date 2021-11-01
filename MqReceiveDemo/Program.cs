using ConsoleApp1.demos.MqDemo;
using EasyNetQ;
using System;

namespace MqReceiveDemo
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("this receive entity");
            MessageQueueReceiverDemo.ReceiveEntity();
           
        }
    }
}
