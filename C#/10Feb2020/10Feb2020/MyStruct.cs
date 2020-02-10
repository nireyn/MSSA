using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Feb2020
{
    struct MyStruct
    {
        int x, y;
        AnotherClass myClass;
        Days myDays;

        public MyStruct(int a, int b, int c)
        {
            myClass = new AnotherClass();
            myClass.number = a;
            x = b;
            y = c;
            myDays = Days.Fri;
        }

        public void PrintStatement()
        {
            Console.WriteLine($"X = {x}, Y = {y}, myDays = {myDays}");

        }
    }

    class AnotherClass
    {
        public int number;

    }
    enum Days {Mon, Tues, Wed , Thur, Fri};
}
