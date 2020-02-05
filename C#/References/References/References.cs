using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    public class Demo
    {
        public static void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine($"My value for a is {a} inside the method.");
        }

        public static void PassByRef(int a)
        {
            a = 5;
            Console.WriteLine($"a[0] = {a}.");
        }
    }
    class References
    {
        public static int CopyCat(int a)
        {
            a += 4;
            return a;
        }
        public static void PassDat(ref int a)
        {
            a += 4;
        }
        static void Main(string[] args)
        {
            int myint = 6;
            PassDat(ref myint);
            int myNewInt = CopyCat(myint);
            Console.WriteLine($"With our powers combined we become {myint}");
            Console.WriteLine($"I had to create a new variable for the CopyCat" +
                $" method because it creates a copy, myNewInt is {myNewInt}");
            int a = 2;
            int b = 10;
            Demo.PassByValue(a);
            Demo.PassByRef( b);
            Console.WriteLine($"b[0] = {b}");
            Console.WriteLine($"a = {a}.");
            
        }
    }
}
