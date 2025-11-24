using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThirdTask
    {
        public static void Thirdtask()
        {
            Console.WriteLine("Enter sum:");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the currency we are converting:");
            Console.WriteLine("1-USD");
            Console.WriteLine("2-EUR");
            Console.WriteLine("3-UAH");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the currency to convert to:");
            Console.WriteLine("1-USD");
            Console.WriteLine("2-EUR");
            Console.WriteLine("3-UAH");
            int to = int.Parse(Console.ReadLine());
            double result = ConvertCurrency(amount, from, to);
            Console.WriteLine("Result:" + result);
        }
        static double ConvertCurrency(double amount,int from,int to)
        {
            double usd = 42.0;
            double eur = 48.45;
            double amountUAH = 0.02;
            if (from == 1)
                amountUAH = amount * usd;
            else if (from == 2)
                amountUAH = amount * eur;
            else if (from == 3)
                amountUAH = amount;
            else
            {
                Console.WriteLine("Incorrect currency selection");
                return 0;
            }
            if (to == 1)
                return amountUAH / usd;
            else if (to == 2)
                return amountUAH / eur;
            else if (to == 3)
                return amountUAH;
            else
            {
                Console.WriteLine("Incorrect currency selection");
                return 0;
            }
        }
    }
}
