using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Feb2020
{
    class Program
    {
        static void Main(string[] args)
        {
            deptEmployee e1 = new deptEmployee();
            e1.InsertData(101, "Bob", "Sales");
            e1.DisplayData();
            deptEmployee e2 = new deptEmployee();
            e2.InsertData(102, "Daisy Duck", "HR");
            e2.DisplayData();

        }
    }
}
