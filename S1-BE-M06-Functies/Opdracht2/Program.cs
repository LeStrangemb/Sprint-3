using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write(isWeekend());
            Console.ReadLine();
           
         
        }
        public static string isWeekend()
        {
           DateTime now = DateTime.Now;
            if ((now.ToString("dddd") == "Saturday") || (now.ToString("dddd") == "Sunday"))
            {
                Console.Write("Het is geen weekend");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Het is weekend");
                Console.ReadLine();
            }
            return isWeekend();
        }
    }
}
