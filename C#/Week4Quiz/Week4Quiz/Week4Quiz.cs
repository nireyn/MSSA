using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Quiz
{
    class Week4Quiz
    {
        static void Main(string[] args)
        {
            DemoRefParameter a = new DemoRefParameter();
            List<int> b = new List<int> { 11, 21, 31, 41, 51 };
            Console.WriteLine($"b[0] before method: {b[0]}.");
            a.PassByReference(b);
            Console.WriteLine($"b[0] after method: {b[0]}.");
        }
    }
}
