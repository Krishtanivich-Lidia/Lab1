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
            int[] array = { 5, 8, 9, 12, 67,14,2,9 };
            int target = 2;
            int index = -1;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]==target)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine("Index:" + index);
            Console.ReadLine();
        }
    }

}
