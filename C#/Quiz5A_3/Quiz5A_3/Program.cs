using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5A_3
{
    class Program
    {
        public struct Birthday
        {
            public int bday, byear;
            public months bmonth;

        }
        public enum months { January = 1, February = 2, March =3, April =4, May = 5, June = 6, July = 7, August = 8, Spetember = 9, October =10, November = 11, December = 12 };
        static void Main(string[] args)
        {
            Birthday myBirthday;
            myBirthday.bday = 31;
            myBirthday.byear = 1993;
            myBirthday.bmonth = (months) 8;
            Console.WriteLine($"My birthday is {myBirthday.bmonth} {myBirthday.bday}, {myBirthday.byear}.");

        }
    }
}
