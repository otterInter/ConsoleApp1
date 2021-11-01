using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.AttributDemo
{
    public class PersonCheckFun
    {
        public static bool Validate(object obj)
        {
            var sttrs = obj.GetType();
            foreach (var item in sttrs.GetProperties())
            {
                var attributes = item.GetCustomAttributes(default);
                foreach(var att in attributes) 
                {
                    var kind = (PersonCheck)att;
                    var result= kind.PersonKind switch
                    {
                        PersonKinds.Yellow=>true,
                        PersonKinds.Black=>false,
                        PersonKinds.White=>false,
                        _=>false
                    };

                    if (!result)
                    {
                        continue;
                    }
                    else
                    {
                        return result;
                    }
                }
            }

            return false;
        }
    }
}
