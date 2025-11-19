using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SixTask
    {
        public static void Sixtask()
        {
            int[] numbers = { 5,- 2, 9, 17, 0, -3, };
            int result = GetProductofNegativeNumbers(numbers);
            Console.WriteLine("Product:" + result);
        }
        static int GetProductofNegativeNumbers(int[]array)
        {
            int product = 1;
            bool hasNegative = false;
            foreach(int num in array)
            {
                if(num<0)
                {
                    product *= num;
                    hasNegative = true;
                }
            }
            return product;
        }
    }
}
