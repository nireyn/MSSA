using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Feb2020
{
    class Student
    {
        private int id;
        private int age;
        private string name;
        string subject;

        public Student(int id, int age, string name, string subject)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.subject = subject;
        }

        public void showInfor()
        {
            Console.WriteLine($"Hi I am {name}, my student ID is {id}, I am {age} years old, and I love {subject}.");
        }
    }
}
