using System;

namespace OOP
{ 
    public enum Gender
    {
        Male,
        Female
    }

    public class Cat
    {
        public string Name { get; }
        public Gender Gender { get; }

        private double _energy;
        public double Energy
        {
            get { return _energy; }
            private set
            {
                if (value < MinEnergy)
                    throw new Exception("Not enough energy to jump");
                _energy = value > MaxEnergy ? MaxEnergy : value;
            }
        }
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;
        public Cat(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy; 
        }

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
            Console.WriteLine($"{Name} jump! Energy: {Energy}");
        }
        public void Sleep()
        {
            Energy += SleepEnergyGain;
            Console.WriteLine($"{Name} sleep! Energy: {Energy}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Murchik", Gender.Male);

            Console.WriteLine($"{myCat.Name}, Gender: {myCat.Gender}, initial energy: {myCat.Energy}");
            Console.WriteLine();
            Console.WriteLine("Кіт стрибає:");
            try
            {
                for (int i = 0; i < 50; i++) 
                {
                    myCat.Jump();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Cat sleep:");
            myCat.Sleep();
            myCat.Sleep(); 
            Console.WriteLine();
            Console.WriteLine("Stop");
            Console.ReadKey();
        }
    }
}