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
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number = number / 2;
            }
            Console.WriteLine("Binary system:" + binary);
        }
    }
}
