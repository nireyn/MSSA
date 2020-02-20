using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3_20Feb
{
    class Dog
    {
        public string name;
        public string breed;
        private int age;
        public int Age { get { return age; } set { age = value; } }
        public string color;
        public string getName()
        {
            return name;
        }
        public string getBreed()
        {
            return breed;
        }
        public int getAge()
        {
            return age;
        }
        public string getColor()
        {
            return color;
        }
        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }
        static void Main(string[] args)
        {   Dog myDog = new Dog("Spot", "Corgi", 6, "Brown");
            Console.WriteLine($"My dog's name is {myDog.getName()}, it is a " +
                $"{myDog.getBreed()}, it is {myDog.getAge()} years old, and it is {myDog.getColor()}.");

        }
    }
}
