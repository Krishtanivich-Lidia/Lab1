using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EightTask
    {
        public static void Eighttask()
        {
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("GCD:" + a);
        }
    }
}

