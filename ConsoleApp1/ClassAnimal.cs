using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassAnimal
    {
        public static void Classanimal()
        {
            Cat cat = new Cat("Black",4.5f, 23f);
            Dog dog = new Dog("Brown", 12.3f, 28f);
            Console.WriteLine(cat.ToString());
            Console.WriteLine("Cat sound:" + cat.MakeSound());
            Console.WriteLine();
            Console.WriteLine(dog.ToString());
            Console.WriteLine("Dog sound:" + dog.MakeSound());
        }
    }
    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }
        public Animal(string color,float weight)
        {
            Color = color;
            Weight = weight;
        }
        public abstract string MakeSound();
    }
    public abstract class AnimalWithTail:Animal
    {
        public float TailLength { get; set; }
        public AnimalWithTail(string color,float weight,float tailLength)
            : base(color, weight)
        {
            TailLength = tailLength;
        }
    }
    public class Cat:AnimalWithTail
    {
        public Cat(string color,float weight,float tailLength)
            : base(color,weight,tailLength)
        { }
        private string Purr()
        {
            return "purrrrrr";
        }
        private string Meow()
        {
            return "Meow";
        }
        public override string MakeSound()
        {
            return Purr() + Meow();
        }
        public override string ToString()
        {
            return $"This is a Cat, Color={Color},Weigth={Weight},TailLength={TailLength}";
        }
    }
    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength)
            : base(color, weight, tailLength)
        {
        }
        public override string MakeSound()
        {
            return "Wooof";
        }
        public override string ToString()
        {
            return $"This is a Dog, Color={Color},Weight={Weight},TailLength={TailLength}";
        }
    }
}
