using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTest
{
    class Program
    {
        public static (int, int, string) TupleTest(int a, int b)
        {
            int add = a + b;
            int subtract = a - b;

            return (add, subtract, "balls");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("gimme 2 numbas");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //(int add, int subtract) = TupleTest(a, b);
            //Console.WriteLine($"Added {add} subtract {subtract}");
            Console.WriteLine($"{TupleTest(a,b)}");
        }
    }
}
