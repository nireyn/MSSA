using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day1
{
    class Week3Day1
    {
        public static int countme(int i = 10)
        {
            if (i == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(i);
                return countme(i - 1);
            }

        }
        static void Main(string[] args)
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(countme());
            char[] name = { 't', 'e', 'r', 'e', 'n','c','e' };
            foreach(char a in name){
                Console.WriteLine(a);
            }
            char[] gender = { 'm', 'f', 'm', 'f', 'f', 'm', 'f', 'f', 'm' };
            int totalM = 0;
            int totalF = 0;
            foreach(char ch in gender)
            {
                if (ch == 'm')
                    totalM++;
                else if(ch == 'f')
                    totalF++;
            }
            Console.WriteLine($"Total male: {totalM}");
            Console.WriteLine($"Total female: {totalF}");
        }
    }
}
