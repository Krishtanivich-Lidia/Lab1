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
            Console.Write("Enter you age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 12 && age <= 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are not a teenager");
            }

        }
    }
}
