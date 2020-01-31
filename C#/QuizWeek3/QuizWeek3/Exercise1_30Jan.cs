using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz30Jan
{
    class Exercise1_30Jan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            try
            {
                byte input = Convert.ToByte(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Error handling complete.");
            }
        }
    }
}
