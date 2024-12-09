using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klukarka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ime = Console.ReadLine();
            Console.WriteLine("Vavedi ime");
            switch (ime)
            {
                case "R": Console.WriteLine("Vechno blee v chas"); break;
                case "H": Console.WriteLine("Klukarka"); break;
                case "M":
                case "C":
                case "N":
                case "K":
                case "ю":
                case "h":
                    Console.WriteLine("Samo te slushat");
                    break;
                default: Console.WriteLine("Nqma drugi"); break;
            }
            }
        }
}
