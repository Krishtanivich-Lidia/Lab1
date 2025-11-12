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
            Console.Write("Enter a number:");
            int limit = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;
            int count = 0;
            while (a < limit)
            {
                sum += a;
                count++;
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine("The sum of Fibonacci numbers less than" + limit + "=" + sum);
            Console.WriteLine("Numbers of elements:" + count);
        }
    }
}

