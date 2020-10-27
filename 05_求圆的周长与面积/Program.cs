using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_求圆的周长与面积
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 4;//圆的半径
            double are = 3.14 * r * r;
            double Perimeter = 2 * 3.14 * r;
            //输出
            Console.WriteLine("总周长是{0},总的面积{1}",Perimeter,are);
            Console.ReadKey();
        }
    }
}
