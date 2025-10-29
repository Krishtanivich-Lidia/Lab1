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
            Console.Write("Enter one number:");
            int a=int.Parse(Console.ReadLine());

            Console.Write("Enter two number:");
            int b=int.Parse(Console.ReadLine());

            Console.Write("Enter third number:");
            int c=int.Parse(Console.ReadLine());

            int max=Math.Max(a, Math.Max(b,c));
            int min=Math.Min(a, Math.Min(b,c));

            Console.WriteLine($"The largest number:{max}");
            Console.WriteLine($"The smallest number:{min}");
        }
    }
}
