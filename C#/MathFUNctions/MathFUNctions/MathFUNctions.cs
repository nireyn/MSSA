using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFUNctions
{
    class MathFUNctions
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Remainder(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculator: \nEnter your selection.\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Remainder\n6. Exit\n");
                int input = checked(Convert.ToInt32(Console.ReadLine()));
                if (input < 1 || input > 6)
                    throw new Exception("Enter a proper selection.\n");
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Input two numbers separated by the enter key.");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = {checked(Add(a,b))}");
                        break;
                    case 2:
                        Console.WriteLine("Input two numbers separated by the enter key.");
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{c} + {d} = {checked(Subtract(c, d))}");
                        break;
                    case 3:
                        Console.WriteLine("Input two numbers separated by the enter key.");
                        int e = Convert.ToInt32(Console.ReadLine());
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{e} + {f} = {checked(Multiply(e, f))}");
                        break;
                    case 4:
                        Console.WriteLine("Input two numbers separated by the enter key.");
                        int g = Convert.ToInt32(Console.ReadLine());
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{g} + {h} = {checked(Divide(g, h))}");
                        break;
                    case 5:
                        Console.WriteLine("Input two numbers separated by the enter key.");
                        int i = Convert.ToInt32(Console.ReadLine());
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{i} + {j} = {checked(Remainder(i, j))}");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message + "\n");
                Main(args);
            }
            catch(OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message+"\n");
                Main(args);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message+"\n");
                Main(args);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }
    }
}
