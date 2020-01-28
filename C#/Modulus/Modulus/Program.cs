using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    class Program
    {
        public static int fib(int num)
        {
            if(num == 1||num == 0)
            {
                return num;
            }
            else
            {
                return fib(num-1) + fib(num - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, I will tell you whether it is even or odd.");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2 == 1)
            {
                Console.WriteLine("Your number is odd.");
            }
            else
            {
                Console.WriteLine("Your number is even.");
            }

            Console.WriteLine("Give me a number for fib sequence.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The {b} number in the fib sequence is {fib(b)}");
        }
    }
}
