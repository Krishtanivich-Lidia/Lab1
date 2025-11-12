using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoTask
    {
        public static void Twotask()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of the numbers from 1 to 100:" + sum);
        }
    }
}
