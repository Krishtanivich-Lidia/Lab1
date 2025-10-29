using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FirstTask1
    {
        public static void FirstTask()
        {
            Console.Write("Enter one number(number1):");
            int number1=int.Parse(Console.ReadLine());

            Console.Write("Enter two number(number2):");
            int number2=int.Parse(Console.ReadLine());

            bool isDay=number1>=1 && number1<=31;
            bool isMonth=number2>=1 && number2<=12;

            if (isDay && isMonth)
            {
                Console.WriteLine("These numbers can be the day and the month.");
            }
            else
            {
                Console.WriteLine("These numbers cannot be the day and the mont.");
            }
        }
    }
}
