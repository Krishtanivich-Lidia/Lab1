using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static void Eighttask()
    {
        Console.Write("Enter side a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side c:");
        double c = Convert.ToDouble(Console.ReadLine());
        double longest;
        if (a >= b && a >= c)
        {
            longest = a;
            Console.WriteLine("The longest side:a=" + longest);
        }
        else if (b >= a && b >= c)
        {
            longest = b;
            Console.WriteLine("The longest side:b=" + longest);
        }
        else
        {
            longest = c;
            Console.WriteLine("The longest side:c=" + longest);
        }
    }
}
}