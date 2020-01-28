using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, option;
            Console.WriteLine("Welcome to the Calculator: Enter your option (1-4).");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"The first number added to the second number is: {num1+num2}");
                    break;
                case 2:
                    Console.WriteLine($"The first number minus the second number is: {num1-num2}");
                    break;
                case 3:
                    Console.WriteLine($"The first number multiplied by the second number is: {num1*num2}");
                    break;
                case 4:
                    Console.WriteLine($"The first number divided by the second number is: {num1/num2}");
                    break;
                default:
                    Console.WriteLine("Invalid option") ;
                    break;
            }
        }
    }
}
