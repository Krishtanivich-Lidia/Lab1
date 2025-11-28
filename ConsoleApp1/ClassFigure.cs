using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassFigure
    {
        public static void Classfigure()
        {
            Circle circle = new Circle();
            circle.Radius = 5;
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 4;
            rectangle.Height = 7;
            Console.WriteLine("Circle:");
            Console.WriteLine("Area:" + circle.CalculateArea());
            Console.WriteLine("Perimeter:" + circle.CalculatePerimeter());
            Console.WriteLine();
            Console.WriteLine("Rectangle:");
            Console.WriteLine("Area:" + rectangle.CalculateArea());
            Console.WriteLine("Perimeter:" + rectangle.CalculatePerimeter());
        }
    }
    internal class Figure
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }
    internal class Circle : Figure
    {
        public double Radius;
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    internal class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Height * Width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }
    }
}





