using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Feb2020
{
    class Derg
    {
        private string name;
        private string breed;
        private string color;
        private int age;

        public Derg(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetBreed()
        {
            return this.breed;
        }
        public string GetColor()
        {
            return this.color;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void WhoAmI()
        {
            Console.WriteLine($"My dog's name is {name}, their breed is {breed}, it is {color}, and it is {age} years old.");
        }

    }
}
