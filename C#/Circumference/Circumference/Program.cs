using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double rad, rad2, circumference, area;
            Console.WriteLine("Enter the radius of your circle.");
            rad = Convert.ToDouble(Console.ReadLine());

            circumference = rad * 2 * Math.PI;
            Console.WriteLine($"The circumference of your circle is {circumference}");

            Console.WriteLine("Enter the radius of your second circle");
            rad2 = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * rad2 * rad2;
            Console.WriteLine($"The area of your circle is {area}");*/

            double a, b, c, p, area2;
            Console.WriteLine("Enter the 3 sides of your triangle separated by the enter key.");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;
            area2 = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            Console.WriteLine($"The area of your triangle is {area2}");

        }
    }
}
