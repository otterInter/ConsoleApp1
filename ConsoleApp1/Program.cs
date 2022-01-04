using ConsoleApp1.demos.FunDemo;
using Microsoft.International.Converters.PinYinConverter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 方法委托demo
            int i = 0;
            var demo = new DoSometingDemo(i, ChangeRemark, ChangeRemarkDelegate);
            Console.WriteLine(JsonConvert.SerializeObject(demo));
            #endregion

            #region 自定义标签使用demo
            //var person = new Person("?");
            //if (PersonCheckFun.Validate(person))
            //{
            //    Console.WriteLine("Person Yellow");

            //} 
            #endregion

            #region 拼音demo
            //string name = "单依纯";
            //List<string> str = GetBigWords(name);
            //Console.WriteLine(string.Join(",", str)); 
            #endregion
        }

        public static string ChangeRemark(int i)
        {
            return i switch
            {
                0 => "零",
                1 => "一",
                _ => "无"
            };
        }

        public static string ChangeRemarkDelegate(int i)
        {
            return i switch
            {
                0 => "零" + i,
                1 => "一" + i,
                _ => "无"
            };
        }

        public static List<string> GetBigWords(string name)
        {
            List<List<string>> StrLists = new List<List<string>>();
            foreach (var item in name)
            {
                ChineseChar chineseChar = new ChineseChar(item);
                StrLists.Add(chineseChar.Pinyins.Where(i => i != null).Distinct().Select(i => i[0].ToString()).ToList());
            }
            List<string> strs = new List<string>();
            GetAllStrList(StrLists, 0, ref strs);
            return strs;
        }

        public static void GetAllStrList(List<List<string>> Strs, int i, ref List<string> updateStr)
        {
            List<string> strList = new List<string>();
            if (i + 1 > Strs.Count)
            {
                return;
            }
            if (updateStr.Count == 0)
            {
                foreach (var item in Strs[i])
                {
                    strList.Add(item);
                }
                updateStr = strList;
            }
            else
            {
                foreach (var item in updateStr)
                {
                    foreach (var item1 in Strs[i])
                    {
                        strList.Add(item + item1);
                    }
                }
                updateStr = strList;
            }
            GetAllStrList(Strs, i + 1, ref updateStr);
        }
    }
}
