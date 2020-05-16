using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            //int a = 0;
            decimal a = 0;
            decimal b = 0;
            //int b = 0;
            //int c = 0;
            decimal c = 0;
            string s = "";
            Console.WriteLine("请输入操作数1:");
            s = Console.ReadLine();
            //a = Int32.Parse(s);
            decimal.TryParse(s, out a);
            Console.WriteLine("请输入操作数2:");
            s = Console.ReadLine();
            //b = Int32.Parse(s);
            decimal.TryParse(s, out b);
            Console.WriteLine("请输入操作码:");
            s = Console.ReadLine();
            switch (s)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        flag = 0;
                        Console.WriteLine("除零错误!");
                        break;
                    }
                    c = a / b;
                    break;
                default:
                    flag = 0;
                    Console.WriteLine("请输入合法操作符!");
                    break;
            }
            if (flag == 1)
            {
                Console.WriteLine("输出结果是:{0}", c);
            }
            Console.ReadKey();
        }
    }
}
