using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel lege regels wil je hebben?", regels);
            Console.ReadLine();
        }
        public static int legeRegels()
        {
            int regels = 0;
            while (regels < 2)
            {
                Console.WriteLine();
                Console.ReadKey();
            }
            return legeRegels();
        }
    }
}

