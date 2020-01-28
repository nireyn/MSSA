using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Quiz
{
    class Week2Quiz
    {
        public static void SolveQuad(double a, double b, double c)
        {
            double result1, result2;
            double d = Math.Sqrt((b * b) - (4 * a * c));
            if (d == 0)
            {
                result1 = (-1 * b) / 2 * a;
                Console.WriteLine($"The only solution is {result1}");
            }
            else if (d > 0)
            {
                result1 = ((-1 * b) + d) / 2 * a;
                result2 = ((-1 * b) - d) / 2 * a;
                Console.WriteLine($"The positive solution is {result1}");
                Console.WriteLine($"The negative solution is {result2}");
            }
            else
            {
                Console.WriteLine("There are no real solutions.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic equation solver:");
            Console.WriteLine("Please enter your A coefficient.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your B coefficient.");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your C coefficient.");
            double c = Convert.ToDouble(Console.ReadLine());
            SolveQuad(a, b, c);
        }
    }
}
