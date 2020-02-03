using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        public int maxSpeed;
        public string color;


        public void FullThrottle()
        {
            Console.WriteLine($"This car is going too fast");
        }
        public void DescribeCar()
        {
            Console.WriteLine($"This car is {color} and has a max speed of {maxSpeed}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car lambo = new Car();
            lambo.color = "Red";
            lambo.maxSpeed = 1337;
            lambo.FullThrottle();
            lambo.DescribeCar();
        }
    }
}
