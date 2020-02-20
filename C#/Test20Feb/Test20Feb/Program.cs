using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test20Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter an integer.");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 0)
                {
                    Console.WriteLine("Your number is even.");
                }
                else
                    Console.WriteLine("Your number is odd.");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
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
