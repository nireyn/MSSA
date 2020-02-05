using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int total = 0;
                int iter = 0;
                string input;
                Console.WriteLine("Give me up to 5 integers separated by the enter key. (Type 'q' to quit) I will calculate the sum and average.");
                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "q")
                        break;
                    if (iter > 4)
                    {
                        throw new Exception("You have entered more than 5 numbers.");
                    }
                    total += Convert.ToInt32(input);
                    iter++;
                }
                Console.WriteLine($"The sum is {total} and the average is {total / iter}.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Error handling complete.");
            }
        }
    }
}
