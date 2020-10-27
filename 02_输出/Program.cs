using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_输出
{
    class Program
    {
        static string Old = "18"; //成员变量
        static void Main(string[] args)
        {
            
            const string Name = "教练"; //局部变量
            string year = "2018";
            //直接使用+号进行字符串拼接
            Console.WriteLine("姓名:" + Name + "  年龄：" + Old + "  何时来深圳" + year);
            //使用占位符(先占位后填充)，进行字符串拼接
            Console.WriteLine("姓名: {0},  年龄:{1}  到深圳的时间 {2}", Name, Old, year);
            Console.ReadKey();
        }
    }
}
