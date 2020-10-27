using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_一元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;

            int result = 10 + ++Number;
           
            //11
            Console.WriteLine(Number);
            //前++:21 后++:20
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    }
}
