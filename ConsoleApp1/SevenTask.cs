using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SevenTask
    {
        public static void Seventask()
        {
            Console.Write("Enter the temperature in degrees Celsius:");
            double celsius=double.Parse(Console.ReadLine());

            double fahrenheit=(celsius*9/5)+32;

            Console.WriteLine($"Temperature in degrees Fahrenheit: {fahrenheit:F2}");
        }
}
}
