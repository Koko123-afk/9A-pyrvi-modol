using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hokin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vavedi znak +,-,*,/");
            var c = Console.ReadLine();

            switch (c)
                {
                case "+":Console.WriteLine("a+b=" +(a+b));break;
                case "-": Console.WriteLine("a-b=" +(a - b)); break;
                case "*": Console.WriteLine("a*b=" + (a * b)); break;
                case "/": Console.WriteLine("a/b=" + (a / b)); break;

            }
        }
    }
}
