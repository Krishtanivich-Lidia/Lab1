using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FirstTask
    {
        public static void Firsttask()
        {
            int[] numbers =new int[] { 64, 74, 1, 0, 65, 12 };
            int sum = 0;
            for(int i=0;i<numbers.Length ;i++)
            {
                sum += numbers[i];
            }
            double average = Convert.ToDouble(sum) / numbers.Length;
            Console.WriteLine("Array average:" + average);
        }
    }
}
