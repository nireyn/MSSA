using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    class ExtraCredit
    {
        public static bool isPerfect(int num)
        {
            int total = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total+= i;
            }
            if (total == num)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, I will check if it is perfect");
            int input = Convert.ToInt32(Console.ReadLine());
            if (isPerfect(input))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The number is perfect");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number is not perfect");
            }

        }
    }
}
