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
            Console.WriteLine("Enter numbers with a space:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' '); ///розбиває рядок на окремі числа введені через пробіл
            int[] numbers = new int[parts.Length];
            for(int i=0;i<parts.Length;i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }
            FindMinMax(numbers, out int min, out int max);
            Console.WriteLine("The smallest element:" + min);
            Console.WriteLine("The largest element:" + max);

        }
        static void FindMinMax(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
        }

    }
}
