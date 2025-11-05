using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SevenTask
    {
        public static void Seventask()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3.");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 3.");
            }
        }
    }
}
