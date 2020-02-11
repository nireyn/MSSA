using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5A_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pNumbers = { 2, 3, 5, 7, 11, 13, 17 };
            string[] names = { "Mickey", "Minnie", "Donald", "Daisy" };
            int numLen = pNumbers.Length;
            int nameLen = names.Length;
            int num3 = pNumbers[2];
            string name3 = names[2];
            for(int i = 0; i < 3; i++)
            {
                names[i] = Convert.ToString(pNumbers[i]);
            }
            foreach(string nam in names)
            {
                Console.WriteLine(nam);
            }
            Array.Sort(pNumbers);
            Array.Sort(names);
            foreach(int i in pNumbers)
            {
                Console.WriteLine(i);
            }
            foreach(string n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
