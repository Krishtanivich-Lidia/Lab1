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
            int[] numbers = { -3, 5, 11, -1, 8, 0, 1 };
            int result = GetSumOfPossitiveNumbers(numbers);
            Console.WriteLine("Sum :" + result);
            //Console.ReadLine();

        }

        static int GetSumOfPossitiveNumbers(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    sum += num;
                }
            }
            return sum;

        }
    } }
