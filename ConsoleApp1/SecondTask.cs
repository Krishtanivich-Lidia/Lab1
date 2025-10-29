using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SecondTask1
    {
        public static void SecondTask()
        {
            Console.Write("Enter a real number:");
            double number=double.Parse(Console.ReadLine());


            number=Math.Abs(number);
            int firstTwoDigits=(int)(number*100)%100;

            int firstDigit=firstTwoDigits/10;
            int secondDigit=firstTwoDigits%10;

            int sum=firstDigit+secondDigit;

            Console.WriteLine($"{firstDigit}+{secondDigit}={sum}");
        }
    }
}
