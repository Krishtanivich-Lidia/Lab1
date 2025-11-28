using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassFruits
    {
        public string Name { get; set; }
        public static void Classfruit()
        {
            ClassFruits fruit = new ClassFruits();
            fruit.Name = "Fruit";
            Apple apple = new Apple();
            apple.Name = "Apple";
            apple.Variety = "Golden";
            apple.Color = "pink";
            Pear pear = new Pear();
            pear.Name = "Pear";
            pear.Variety = "Bartlett";
            pear.Color = "yellow";
            Console.WriteLine("basic fruit:");
            Console.WriteLine("Name:"+ fruit.Name);
            Console.WriteLine();
            Console.WriteLine("Apple:");
            Console.WriteLine("Name:" + apple.Name);
            Console.WriteLine("Variety:" + apple.Variety);
            Console.WriteLine("Color:" + apple.Color);
            Console.WriteLine();
            Console.WriteLine("Pear::");
            Console.WriteLine("Name:" + pear.Name);
            Console.WriteLine("Variety:" + pear.Variety);
            Console.WriteLine("Color:" + pear.Color);

        }
    }
    internal class Apple: ClassFruits
    {
        public string Variety { get; set; }
        public string Color { get; set; }
    }
    internal class Pear: ClassFruits
    {
        public string Variety { get; set; }
        public string Color { get; set; }
    }
}
