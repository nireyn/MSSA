using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Quiz
{
    class DemoRefParameter
    {
        public void PassByReference(List<int> b)
        {
            b[0] = 5;
            Console.WriteLine($"b[0] is {b[0]}.");
        }

    }
}
