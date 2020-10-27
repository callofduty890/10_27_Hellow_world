using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_引用类型与值类型
{
    class class1
    {
        public int Value = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0;//初始值
            int val2 = val1;//赋值
            val2 = 123;

            class1 ref1 = new class1();//创建对象，new在托管堆中分配空间
            class1 ref2 = ref1;//
            class1 ref3 = null;
            class1 ref4 = new class1();

            ref2.Value = 789;

            Console.WriteLine("Values:{0},{1}", val1, val2);//显示值类型
            Console.WriteLine("Refs:{0},{1}", ref1.Value, ref2.Value);//显示引用类型

            Console.ReadKey();

        }
    }
}
