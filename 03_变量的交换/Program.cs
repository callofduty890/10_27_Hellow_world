using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_变量的交换
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            //思路：1.创建一个第三方变量进行交换 2.通过加减法完成
            int temp = n1;

            n1 = n2;
            n2 = temp;

            Console.WriteLine("交换,n1的值是{0},n2的值是{1}", n1, n2);

            Console.ReadKey();
        }
    }
}
