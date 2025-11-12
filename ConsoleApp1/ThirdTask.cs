using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThirdTask
    {
        public static void Thirdtask()
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "*" + i + "=" + (number * i));
            }
        }
    }
