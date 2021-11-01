using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.AttributDemo
{
   
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        [PersonCheck(PersonKinds.Yellow)]
        public string Name { get; set; }
    }
}
