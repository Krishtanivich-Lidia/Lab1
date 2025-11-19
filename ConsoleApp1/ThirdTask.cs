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
            int[] numbers = new int[] { 34, 56, 12, 45, 1, 367, 987 };
            Console.WriteLine("Even numbers in an array:");
            foreach(int num in numbers)
            {
                if(num%2==0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }
       
    }
}
