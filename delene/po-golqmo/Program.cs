using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_golqmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi edno cqlo 4islo a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("vuvedi edno cqlo 4islo b=");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("po golqmo e" + a);
                Console.WriteLine("po malko e" + b);
            }
            else
            {
                Console.WriteLine("po golqmo e" + b);
                Console.WriteLine("po malko e" + a);
            }

        }
    }
}
