using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, tot, p, t;
            Console.WriteLine("Please enter the principle greater than 0.");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the rate as a decimal percentage. (.1 for 10%)");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the time in years.");
            t = Convert.ToDouble(Console.ReadLine());
            tot = p * (r) * t;
            Console.WriteLine($"The total owed is {p + tot}");

        }
    }
}
