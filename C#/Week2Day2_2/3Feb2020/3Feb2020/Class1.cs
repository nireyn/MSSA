using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Feb2020
{
    public class deptEmployee
    {
        public int id;
        public string name;
        public string department;

        public void InsertData(int ID, string Name, string Department)
        {
            id = ID;
            name = Name;
            department = Department;
        }

        public deptEmployee()
        {

        }

        public void DisplayData()
        {
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Department: {department}");
        }


    }
}
