using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoTask
    {
        public static void Twotask()
        {
            Console.Write("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{year} is leap year.");
            }
            else
            {
                Console.WriteLine("{year} is Not a leap year.");
            }
        }

    }
}
