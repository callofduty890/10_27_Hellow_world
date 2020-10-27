using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_转译字符和_符号的作用
{
    class Program
    {
        static void Main(string[] args)
        {
            //转译字符 - 改变原有字符串的意思，按照指定形式输出  \n 回车
            Console.WriteLine("妹妹你坐船头\n哥哥我岸上走");
            Console.WriteLine("我应该在车底\"\"不应该在车里\"\""); //英文半角
            string name1 = "窗前明月光"; //局部变量
            string name2 = "疑是地上霜";
            string name3 = "举头望明月";
            string name4 = "低头思故乡";
            //\t 增加空格
            Console.WriteLine("{0}\t{1}",name1,name2);
            Console.WriteLine("{0}\t{1}", name3, name4);
            // \b 退格
            Console.WriteLine("我王境泽就是饿死，死外边，我也不\b会吃你们一口东西 嗯 真香");
            
            Console.ReadKey();
        }
    }
}
