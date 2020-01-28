using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popquiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please enter your first number.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number.");
            b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                Console.WriteLine($"The larger number is: {a}");
            }
            else if (a < b)
            {
                Console.WriteLine($"The larger number is {b}");
            }
            else
            {
                Console.WriteLine("The numbers are equal.");
            }
            

        }
    }
}
