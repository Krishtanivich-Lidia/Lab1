using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FourTask
    {
        public static void Fourtask()
        {
            Console.Write("Enter one English letter:");
            char letter = Char.ToUpper(Console.ReadKey().KeyChar);
            if (!Char.IsLetter(letter))
            {
                Console.WriteLine("This is not a letter");
            }
            else if ("AEIOU".Contains(letter))
            {
                Console.WriteLine("This is a vowel letter.");
            }
            else
            {
                Console.WriteLine("This is a consonant letter.");
            }

        }
    }
}