using System;

namespace ShapesApp
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("Circle 1", 18);
            Circle circle2 = new Circle("Circle 2", 19);

            Square square1 = new Square("Square 1", 12);
            Square square2 = new Square("Square 2", 9);
            Shape[] shapes = { circle1, circle2, square1, square2 };

            Console.WriteLine("Information:\n");

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name}: Area = {shape.Area():F2}, Perimeter = {shape.Perimeter():F2}");
            }
            double maxCircleArea = Math.Max(circle1.Area(), circle2.Area());
            double maxSquareArea = Math.Max(square1.Area(), square2.Area());

            Console.WriteLine($"\nlargest circle area: {maxCircleArea:F2}");
            Console.WriteLine($"larges square area: {maxSquareArea:F2}");
        }
    }
}