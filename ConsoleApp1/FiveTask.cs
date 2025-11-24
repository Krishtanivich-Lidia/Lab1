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
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            CountLetters(input, out int vowels, out int consonants);
            Console.WriteLine("Number of vowels:" + vowels);
            Console.WriteLine("Number of consonants:" + consonants);
        }
        static void CountLetters(string text, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach(char c in text.ToLower())
            {
                if (char.IsLetter(c))
                {
                    if (Array.Exists(vowels,v=> v==c))
                        vowelCount ++;
                    else
                        consonantCount++;
                }
               
                    
            }
        }
    }
}
