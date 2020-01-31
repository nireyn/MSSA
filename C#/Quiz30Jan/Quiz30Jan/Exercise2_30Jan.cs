using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz30Jan
{
    class Exercise2_30Jan
    {
        static void Main(string[] args)
        {
            int[] cake = new int[] { 10, 92, 9, -2, 45, -25, 123, 64, 7, 0 };
            Console.WriteLine("Enter the index of the requested value in my array.");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The value at index {input} is {cake[input]}.");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Try...catch block completed.");
            }
        }
    }
}
