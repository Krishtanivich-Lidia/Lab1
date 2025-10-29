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
            Console.Write("Enter number n:");
            int n=int.Parse(Console.ReadLine());

            int sum=n*(n+1)/2;

            Console.WriteLine($"Sum of the first{n} natural number={sum}");
        }
    }
}
