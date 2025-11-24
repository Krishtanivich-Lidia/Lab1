using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SecondTask
    {
        public static void Secondtask()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            if (isPrime)
                Console.WriteLine("The number if prime");
            else
                Console.WriteLine("The number isn't prime");
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for(int i=2;i<number;i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
