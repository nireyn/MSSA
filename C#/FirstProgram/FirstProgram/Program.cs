using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Hello World!");

            Console.WriteLine("Enter a number");
            int x2 = Convert.ToInt32(ReadLine());
            Console.WriteLine("Enter a second number");
            int y2 = Convert.ToInt32(ReadLine());
            //string x = ReadLine();
            //string y = ReadLine();
            int mySum = x2 + y2; ;

            /*int x2 = Read();
            int y2 = Read();
            int mysum2 = x2 * y2;*/
            WriteLine("Your sum is " + mySum);
            //WriteLine(mysum2);
        }
    }
}
