using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SixTask
    {
        public static void Sixtask()
        {
            Console.Write("Enter an integer:");
            int number=int.Parse(Console.ReadLine());

            if (number %2==0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
