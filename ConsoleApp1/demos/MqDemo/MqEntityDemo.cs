using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.MqDemo
{
    public class MqEntityDemo
    {
        public MqEntityDemo(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id { get; }
        public string Name { get; }

        public int Age { get; set; }
    }
}
