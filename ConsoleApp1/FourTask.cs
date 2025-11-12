using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FourTask
    {
        public static void Fourtask()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of a number" + n + "=" + factorial);
        }
    }
}
