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
         while (legeRegels() > 10)
            {
                string resultaat = legeRegels;
                Console.Write(resultaat);
            }
        }
        public static int legeRegels()
        {
            Console.Write("Hoeveel lege regels wil je? ");
            Console.ReadLine();
            return legeRegels();
        }
    }
}

