using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Feb2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FiggleFonts.Colossal.Render("Suck it"));
            Student tony = new Student(123, 26, "Big Tony", "math");
            tony.showInfor();
            MyStruct n1 = new MyStruct(1, 2, 3);
            n1.PrintStatement();
            Person p1;
            p1.name = "Mickey Mouse";
            p1.age = 90;
            p1.weight = 120;
            Console.WriteLine($"P1 name {p1.name}, p1 age {p1.age}, p1 weight {p1.weight}.");
        }
    }
}
