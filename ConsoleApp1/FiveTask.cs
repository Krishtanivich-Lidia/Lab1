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
            Console.Write("Enter the length of the rectangle:");
            double length=double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle:");
            double width=double.Parse(Console.ReadLine());

            double area=length*width;

            Console.WriteLine($"The area of the rectangle={area}");
        }
    }
}
