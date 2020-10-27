using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_一元运算符的练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            int E = a++;

            Console.WriteLine("a:{0},E:{1}", a, E);

            int D = ++a;

            Console.WriteLine("a:{0},D:{1}", a, D);

            int F = --a;

            Console.WriteLine("a:{0},F:{1}", a, F);

            int G = a++;
            Console.WriteLine("a:{0},G:{1}", a, G);

            int b = E + D * 2 + F + G;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
