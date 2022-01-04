using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demos.FunDemo
{
    public class DoSometingDemo
    {
        public DoSometingDemo(int _inter, Func<int, string> changeRemark, ChangeRemarkDelegate changeRemarkDelegate)
        {
            _changeRemark = changeRemark;
            RemarkFunStr = _changeRemark(_inter);
            _changeRemarkDelegate = changeRemarkDelegate;
            RemarkDelegateStr = _changeRemarkDelegate(_inter);
        }


        public string RemarkFunStr { get; set; }

        public string RemarkDelegateStr { get; set; }

        public delegate string ChangeRemarkDelegate(int input);

        protected Func<int, string> _changeRemark;

        protected ChangeRemarkDelegate _changeRemarkDelegate;
    }
}
