using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_20Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 2] { { 2, 3 }, { 6, 9 }, { 21, 73 } };
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
