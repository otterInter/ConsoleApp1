using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.FunDemo
{
    public class DoSometingDemo
    {
        public  DoSometingDemo(int _inter,Func<int, string> chanageRemark)
        {
            ChanageRemark = chanageRemark;
            Remark = ChanageRemark(_inter);
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; }

        protected Func<int, string> ChanageRemark;
    }
}
