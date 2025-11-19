using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoTask
    {
        public static void Twotask()
        {
            char[] letters =new char[] { 'm', 'a', 'd', 'a', 'm' };
            bool isPalindrom = true;
            int halfLength = letters.Length / 2;
            for(int i = 0; i < halfLength;i++)
            {
                if (letters[i] != letters[letters.Length - 1-i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            if(isPalindrom)
            {
                Console.WriteLine("Array is a pallindrome.");
            }
            else
            {
                Console.WriteLine("Array is not a pallindrome.");
            }
        }
    }
}
