using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _10Feb20_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrollPicture t = new TrollPicture();
            Console.ForegroundColor = ConsoleColor.White;
            int[] even = { 2, 4, 6, 8, 10 };
            int[] odd = { 1, 3, 5, 7, 9 };
            Array.Copy(even, odd, 3);
            foreach(int i in even)
            {
                Console.WriteLine("even array " + i);
            }
            foreach(int i in odd)
            {
                Console.WriteLine("odd array " +i);
            }
            double[] numbers = { -10.2, -3.3, -5.6, 35.1, 101.3, -99.19 };
            Array.Sort(numbers);
            foreach(double i in numbers)
            {
                Console.WriteLine("sorted " + i);
            }

            int[] myNumbers = { 5, 1, 8, 9, 119988, 52,34,567,89 };
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());
            Console.WriteLine(Array.IndexOf(myNumbers,52));

            int[] nums = { 100, 35, 2, 11, 23, 3, 11 };
            Console.WriteLine($"Mean: {nums.Sum()/nums.Length}");
            Array.Sort(nums);
            Console.WriteLine($"Median: {nums[nums.Length/2]}");



        }
    }
}
