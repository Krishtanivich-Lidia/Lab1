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
            Console.WriteLine("Simple income tax calculator");
            Console.WriteLine("Enter your annual income:");

            if (double.TryParse(Console.ReadLine(), out double income))
            {
                double taxRate = 0.0;
                double taxAmount = 0.0;
                if (income < 0)
                {
                    Console.WriteLine("Error:Income cannot be negative.");
                }
                else if (income <= 20000)
                {
                    taxRate = 0.10;//10%
                }
                else if (income <= 50000)
                {
                    taxRate = 0.15;//15%
                }
                else if (income <= 100000)
                {
                    taxRate = 0.20;//20%
                }
                else
                {
                    taxRate = 0.30;//30%
                }
                taxAmount = income * taxRate;
                double netIncome = income - taxAmount;
                Console.WriteLine($"Calculation Summary");
                Console.WriteLine($"Annual Income: {income:C2}");
                Console.WriteLine($"Applicable Tax Rate: {taxRate:P1}");
                Console.WriteLine($"Tax Amount Due: **{taxAmount:C2}");
                Console.WriteLine($"Net Income (After Tax): **{netIncome:C2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for your income.");
            }
        }
    }
}
