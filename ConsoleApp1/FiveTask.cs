using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FiveTask
    {
        public static void Fivetask()
        {
            int sum = 0;
            for (int i = 2; i <= 50; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of prime numbers from 1 to 50:" + sum);

        }
    }
}
