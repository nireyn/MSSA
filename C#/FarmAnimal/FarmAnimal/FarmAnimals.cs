using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            TrollPicture p = new TrollPicture();
            Console.ForegroundColor = ConsoleColor.White;
            Pig tom = new Pig();
            tom.Speak();
            Sheep tony = new Sheep();
            tony.Speak();
            Dog manny = new Dog();
            manny.Speak();
            Horse t = new Horse("tomtom", "Stallion");
            t.Speak();
            Console.WriteLine($"My horse's name is {t.GetName()}");
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tom.Eat();
            tony.Eat();
            tony.Eat();
            tony.Eat();
            tony.Eat();
            manny.Eat();
            manny.Eat();
            manny.Eat();
            t.Eat();
            t.Eat();
            t.Eat();
            t.Eat();
            t.Eat();

            Console.WriteLine($"My horse is {t.GetWeight()} fatness units.");
            Console.WriteLine($"My dog is {manny.GetWeight()} fatness units.");
            Console.WriteLine($"My sheep is {tony.GetWeight()} fatness units.");
            Console.WriteLine($"My pig is {tom.GetWeight()} fatness units.");
        }
    }
    class Pig
    {
        private int HowFat = 1;
        public void Speak()
        {
            Console.WriteLine("Oink.");
        }
        public void Eat()
        {
            HowFat++;
        }
        public int GetWeight()
        {
            return HowFat;
        }
    }
    class Sheep
    {
        private int HowFat = 1;
        public void Speak()
        {
            Console.WriteLine("Baaa.");
        }
        public void Eat()
        {
            HowFat++;
        }
        public int GetWeight()
        {
            return HowFat;
        }
    }
    class Dog
    {
        private int HowFat = 1;
        public void Speak()
        {
            Console.WriteLine("Bark.");
        }
        public void Eat()
        {
            HowFat++;
        }
        public int GetWeight()
        {
            return HowFat;
        }
    }
    class Horse
    {
        private int HowFat = 1;
        private string Name;
        private string Type;
        public Horse(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public void Speak()
        {
            Console.WriteLine("Neigh.");
        }
        public string GetName()
        {
            return Name;
        }
        public void Eat()
        {
            HowFat++;
        }
        public int GetWeight()
        {
            return HowFat;
        }

    }
}
