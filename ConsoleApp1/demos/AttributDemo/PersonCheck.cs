using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.AttributDemo
{
    [AttributeUsage(AttributeTargets.All)]
    public class PersonCheck:Attribute
    {
        public PersonCheck(PersonKinds personkinds)
        {
            PersonKind = personkinds;
        }
        public PersonKinds PersonKind { get; }
    }

    public enum PersonKinds
    {
        White,
        Yellow,
        Black
    }
}
