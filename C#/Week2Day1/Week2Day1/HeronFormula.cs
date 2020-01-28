using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class HeronFormula
    {
        public static double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            if(a>p || b>p || c > p)
            {
                Console.WriteLine("The sides provided will not form a triangle.");
                return 0;
            }
            double area1 = Math.Sqrt(p * (p - a) * (p - b)*(p - c));
            return area1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the three sides of your triangle separated by the enter key.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your triangle is {Area(a,b,c)}");

        }
    }
}
