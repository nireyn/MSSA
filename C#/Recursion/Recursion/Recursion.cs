using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculateAverages
{
    class Average
    {

        public static double CalcPhi(int iter = 1)
        {
            double Fibme(int x)
            {
                if (x == 0 || x == 1)
                    return x;
                else
                    return Fibme(x - 1) + Fibme(x - 2);
            }
            if (iter == 40)
            {
                Console.WriteLine($"The value of Phi is: {Fibme(iter) / Fibme(iter - 1)}");
                return 0;
            }
            else
            {
                Console.WriteLine($"{iter}. {Fibme(iter-1)} + {Fibme(iter)} =  {Fibme(iter-1) + Fibme(iter)}");
                return CalcPhi(iter + 1);
            }
        }
        public static int RecurGrade(int total = 0, int score = 0, int iter = 0)
        {
            Console.WriteLine("Hit me with a test score (0-100). Enter -1 to quit.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == -1)
            {
                Console.WriteLine($"Your average is: { (total + score) / iter}");
                if ((total + score) / iter >= 90 && (total + score) / iter <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your grade is an A.");
                }
                else if ((total + score) / iter < 90 && (total + score) / iter >= 80)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your grade is a B.");
                }
                else if ((total + score) / iter < 80 && (total + score) / iter >= 70)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your grade is a C.");
                }
                else if ((total + score) / iter < 70 && (total + score) / iter >= 60)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Your grade is a D.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your grade is a F.");
                }
                return total + score;
            }
            else
                return RecurGrade(total + score, input, iter + 1);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CalcPhi();
            RecurGrade();
            /*double total = 0;
            string input;
            double input2=0;
            double count=0;

            do
            {
                Console.WriteLine("Enter a test grade. (0-100) Enter a number outside of that range to quit.");
                input = Console.ReadLine();
                //little input validation checking whether or not it starts with a letter and has any number of letters.
                if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("I am looking for a number. Please enter in a number.");
                    continue;
                }
                //escape condition is the user putting in something out of the range.
                if (Convert.ToDouble(input) > 100 || Convert.ToDouble(input) < 0)
                {
                    break;
                }
                input2 = Convert.ToDouble(input);
                total += input2;
                count++;
            } while (input2 >= 0 && input2 <= 100);

            if (count == 0) //so NaN isn't the answer
                count++;

            double avg = total / count;
            Console.WriteLine($"Your average is {avg}.");

            if(avg >=90 && avg <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your grade is an A.");
            }
            else if(avg<90 && avg >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your grade is a B.");
            }
            else if(avg<80 && avg >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your grade is a C.");
            }
            else if (avg < 70 && avg >= 60)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Your grade is a D.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your grade is a F.");
            }*/
        }
    }
}
