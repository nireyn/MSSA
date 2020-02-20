using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5_20Feb
{
    class Program
    {
        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }
        static void Main(string[] args)
        {
            //int commonDiv = 1;
            Console.WriteLine("Give me 2 integers separated by the enter key.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The greatest common divisor is: {GCD(input1,input2)}.");
            //int[] divisors1 = new int[input1];
            //int indexCount1 = 0;
            //int[] divisors2 = new int[input2];
            //int indexCount2 = 0;
            //for(int i = 1; i <= input1; i++)
            //{
            //    if (input1 % i == 0)
            //    {
            //        divisors1[indexCount1] = i;
            //        indexCount1++;
            //    }
            //}
            //for(int i = 1; i <= input2; i++)
            //{
            //    if (input2 % i == 0)
            //    {
            //        divisors2[indexCount2] = i;
            //        indexCount2++;
            //    }
            //}
            //if (input2 > input1)
            //{
            //    for(int i = 0; i < divisors1.Length; i++)
            //    {
            //        if (divisors1.Contains(divisors2[i]) && divisors2[i] != 0)
            //            commonDiv = divisors2[i];
            //    }
            //    Console.WriteLine($"The greatest common divisor is: {commonDiv}.");
            //}
            //else if (input2 < input1)
            //{
            //    for(int i = 0; i < divisors2.Length; i++)
            //    {
            //        if (divisors2.Contains(divisors1[i]) && divisors1[i]!=0)
            //        {
            //            commonDiv = divisors1[i];
            //        }
            //    }
            //    Console.WriteLine($"The greatest common divisor is: {commonDiv}.");
            //}
            //else
            //{
            //    Console.WriteLine($"The greatest common divisor is: {input1}.");
            //}
        }
    }
}
