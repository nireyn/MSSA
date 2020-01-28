using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day2
{
    class Book
    {
        public string title;
        public string author;
        public int numPages;
    }
    class Program
    {
        public int AddArr(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Book better = new Book();
            better.author = "atul gawande";
            better.numPages = 163;
            better.title = "Better";
            Program cake = new Program();
            int[] numbers = new int[] { 5, -8, 3, 14, 9, 17, 0, 4 };
            Console.WriteLine($"The largest number in the array is {cake.AddArr(numbers)}");

            try
            {
                Console.WriteLine("Give me the radius of your circle.");
                int rad = Convert.ToInt32(Console.ReadLine());
                if (rad <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Cannot have a zero or negative radius.");
                }
                double circum = 2 * Math.PI * (double) rad;
                Console.WriteLine($"The circumference of your cirlce is {circum}");
            }
            catch(Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Try...Catch has completed.");
            }

            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                double result1, result2;
                Console.WriteLine("Enter 3 integer coefficients separated by the enter key.");
                int a2 = Convert.ToInt32(Console.ReadLine());
                int b2 = Convert.ToInt32(Console.ReadLine());
                int c2 = Convert.ToInt32(Console.ReadLine());
                double d = Math.Sqrt((b2 * b2) - (4 * a2 * c2));
                if (d == 0)
                {
                    result1 = (-1 * b2) / 2 * a2;
                    Console.WriteLine($"The only solution is {result1}");
                }
                else if (d > 0)
                {
                    result1 = ((-1 * b2) + d) / 2 * a2;
                    result2 = ((-1 * b2) - d) / 2 * a2;
                    Console.WriteLine($"The positive solution is {result1}");
                    Console.WriteLine($"The negative solution is {result2}");
                }
                else
                {
                    throw new Exception("The numbers provided offer no real solutions.");
                }
            }
            catch (Exception er)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(er.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Quadratic try..catch has completed.");
            }
        }
    }
}
