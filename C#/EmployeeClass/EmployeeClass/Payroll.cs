using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee
    {
        private string name;
        private int hourWorked;
        private const int hourRate = 8;
        public static int Exemption { get; set; }
        public int totalWorkHours
        {
            get { return hourWorked; }
            set {  hourWorked = value; }
        }
        public string Name { get { return name; } set { name = value; } }
        public static void DisplayExemption()
        {
            Console.WriteLine($"Your exemption is = {Exemption}");
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating your pay...");
        }
        public int PayCalculation()
        {
            this.PrintMessage();
            int employeePay = hourWorked * hourRate;
            if (hourWorked > 0)
                return employeePay;
            else
                return 0;
        }
        public int PayCalculation(int allowance, int bonus)
        {
            this.PrintMessage();
            int employeePay = (hourWorked * hourRate) + allowance + bonus;
            if (hourWorked > 0)
                return employeePay;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"Employee name: {name}, HourRate: {hourRate}, HoursWorked: {hourWorked}";
        }

        public Employee(string Name)
        {
            name = Name;
            hourWorked = 0;
        }
        public Employee(string firstName, string lastName)
        {
            name = firstName + " " + lastName;
            hourWorked = 0;
        }
        public static void Details()
        {
            Console.WriteLine("Static method.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Shrek");
            Employee e2 = new Employee("Mickey", "Mouse");
            Employee e3 = new Employee("Billy", "Bob");
            Employee.Exemption = 0;
            e1.totalWorkHours = 400;
            e2.totalWorkHours = 40;
            e3.totalWorkHours = 20;
            int money = e1.PayCalculation(350,150);
            int bonus = e2.PayCalculation();
            int money2 = e3.PayCalculation();
            Console.WriteLine($"{e1.ToString()}");
            Console.WriteLine($"{e1.Name}'s money is {money}.");
            Employee.DisplayExemption();
            Console.WriteLine($"{e2.ToString()}");
            Console.WriteLine($"{e2.Name}'s money is {bonus}.");
            Employee.Exemption = 21;
            Employee.DisplayExemption();
            Console.WriteLine($"{e3.ToString()}");
            Console.WriteLine($"{e3.Name}'s money is {money2}.");
            Employee.Exemption = 1;
            Employee.DisplayExemption();
        }
    }
}
