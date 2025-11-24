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
            Console.WriteLine("Choose figures:circle,rectangle,cube");
            string figure = Console.ReadLine();
            if(figure=="circle")
            {
                CalculateCircle();
            }
            else if (figure=="rectangle")
            {
                CalculateRectangle();
            }
            else if (figure=="cube")
            {
                CalculateCube();
            }
            else
            {
                Console.WriteLine("Unknown figure");
            }
        }
        static void CalculateCircle()
        {
            Console.Write("Enter radius:");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("Area circle:" + area);
        }
        static void CalculateRectangle()
        {
            Console.Write("Enter length:");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width:");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("Area rectangle:" + area);
        }
        static void CalculateCube()
        {
            Console.Write("Enter leght edge of a cube:");
            double a = double.Parse(Console.ReadLine());
            double area = 6 * a * a;
            double volume = a * a * a;
            Console.WriteLine("Surface area of a cube:" + area);
            Console.WriteLine("Volume of a cube:" + volume);
        }

    }
}
