using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4Feb_2
{
    class Program
    {
        class Staff
        {
            private string name;
            public string Name { get { return name; } set { name = value; } }
            private const int hourRate = 15;
            private int hWorkedOverTime;
            public int HoursWorked { get { return hWorkedOverTime; } set { hWorkedOverTime = value; } }
            public double CalculateOvertimePay()
            {
                return hWorkedOverTime * 1.5;
            }
            public Staff(string Name)
            {
                name = Name;
            }
        }
        static void Main(string[] args)
        {
            Staff s1 = new Staff("Mickey Mouse");
            s1.HoursWorked=5;
            Console.WriteLine($"My staff's name is {s1.Name} and his overtime pay is {s1.CalculateOvertimePay()}.");
        }
    }
}
