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
            Console.WriteLine("Enter a first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation(=,-,*,/):");
            string op = Console.ReadLine();
            Console.WriteLine("Enter a second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Calculate(a, b, op);
            Console.WriteLine("Result:" + result);
        }
        static double Calculate(double x,double y, string operation)
        {
            if (operation == "+")
                return x + y;
            if (operation == "-")
                return x - y;
            if (operation == "*")
                return x * y;
            if(operation=="/")
            {
                if(y==0)
                {
                    Console.WriteLine("Error");
                    return 0;
                }
                return x / y;
            }
            Console.WriteLine("Unknown operation");
            return 0;
        }
    }
}
