using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class MonteCarlo
    {
        public static double Hypo(Random rand)
        {
            (double, double) a = (rand.NextDouble(), rand.NextDouble());
            double hypot = Math.Sqrt((a.Item1 * a.Item1) + (a.Item2 * a.Item2));
            return hypot;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many iterations would you like to run?");
            double iter = Convert.ToDouble(Console.ReadLine());
            Random ran = new Random();
            double over = 0;
            for(int i = 1; i <= iter; i++)
            {
                double hyp = Hypo(ran);
                if (hyp <= 1)
                {
                    over++;
                }
            }
            Console.WriteLine($"Result: {(over / iter) * 4} and the difference is {Math.Abs(Math.PI- ((over / iter) * 4))}");
            /*How many iterations would you like to run?
              10
              Result: 2.8 and the difference is 0.341592653589793
              Press any key to continue . . .*/
            /*How many iterations would you like to run?
              100
              Result: 3.44 and the difference is 0.298407346410207
              Press any key to continue . . .*/
            /*How many iterations would you like to run?
              1000
              Result: 3.232 and the difference is 0.0904073464102071
              Press any key to continue . . .*/
            /*How many iterations would you like to run?
              10000
              Result: 3.136 and the difference is 0.005592653589793
              Press any key to continue . . .*/
}
}
}
