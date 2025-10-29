using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThirdTask1
    {
        public static void Thirdtask()
        {
            Console.Write("Enter hours(0-23):");
            int h=int.Parse(Console.ReadLine());

            if (h>=5 && h<12)
            {
                Console.WriteLine("Good day!");
            }
            else if (h>=12 && h<18)
            {
                Console.WriteLine("Good day!");
            }
            else if (h>=18 && h<22)
            {
                Console.WriteLine("Good night!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }
        }
    }
}
