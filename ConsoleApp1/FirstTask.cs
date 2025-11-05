using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FirstTask
    {
        public static void Firsttask()
        {
            Console.WriteLine("Enter an integer:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > 0)
                    Console.WriteLine($"You enterned a number {number}.This is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"You enterned a number {number}.This is a negative number.");
            }
            else
            {
                Console.WriteLine($"You enterned a number {number}.It is zero.");
            }

        }

    }
}
