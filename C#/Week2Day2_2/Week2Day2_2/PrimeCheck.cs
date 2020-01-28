using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2_2
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int[] myNum = { 2, 3, 5, 7, 11, 13, 17, 19, 21 };

            foreach(int i in myNum)
            {
                bool isPrime = false;
                int numDivBy = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numDivBy++;
                    }
                }
                if (numDivBy == 2)
                {
                    isPrime = true;
                }
                if (isPrime && i!=2)
                {
                    Console.WriteLine($"This number is prime and is not 2: {i}");
                }
                continue;
                Console.WriteLine(i);
            }
        }
    }
}
