using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4_20Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            int outLoop = 0;
            int inLoop = 0;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    inLoop++;
                }
                outLoop++;
            }
            Console.WriteLine($"The value of the outer loop counter after execution is: {outLoop}.");
            Console.WriteLine($"The value of the inner loop counter after execution is: {inLoop}.");
        }
    }
}
