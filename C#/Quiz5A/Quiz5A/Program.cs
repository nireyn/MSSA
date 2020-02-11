using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5A
{
    class Program
    {
        static void Main(string[] args)
        {
            moonStruct a;
            a.x = 15;
            a.y = 25;
            int sum = a.x + a.y;
            Console.WriteLine($"x + y = {sum}");
        }
    }
}
