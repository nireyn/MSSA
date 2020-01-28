using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C
{
    class Lab3C
    {
        public static void Tuition(int year)
        {
            double total = 0;
            for(int i = 0; i < year; i++)
            {
                total = 6000 * (Math.Pow(1.02, i));
                Console.WriteLine($"For year {i+1} your tuition is {total}");
            }
        }
        public static double RecurTuition(double year=1, double total=6000, int iter=1)
        {
            if (year == 1)
            {
                Console.WriteLine($"Your recursive total for {iter} years will be {total}");
                return 0;
            }
            else
                return RecurTuition(year - 1,total+6000*(Math.Pow(1.02,iter)),iter+1);
        }
        public static void FeetToInches(double feet)
        {
            Console.WriteLine($"{feet} Feet is {feet*12} inches.");
        }
        public static void Greater(int x, int y)
        {
            if(x>y)
                Console.WriteLine($"{x} is greater than {y}");
            else if(y>x)
                Console.WriteLine($"{y} is greater than {x}");
            else
                Console.WriteLine($"{x} is equal to {y}");
        }
        public static (int, int) Greater2(int x, int y)
        {
            if (x > y)
                return (x, y);
            else if (y > x)
                return (y, x);
            else
                return (x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tuition\n");
            Console.WriteLine("How many years are you going to school?");
            int year = Convert.ToInt32(Console.ReadLine());
            Tuition(year);
            RecurTuition(year);
            Console.WriteLine("\nConvert to inches: How many feet?");
            double feet = Convert.ToDouble(Console.ReadLine());
            FeetToInches(feet);
            Console.WriteLine("\nGreater than: Enter two numbers separated by the enter key.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Greater(x, y);
            Console.WriteLine($"Greater 2: {Greater2(x,y).Item1} is greater than {Greater2(x,y).Item2}");
        }
    }
}
