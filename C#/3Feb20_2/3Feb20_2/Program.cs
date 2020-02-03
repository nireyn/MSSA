using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Feb20_2
{
    public class user
    {
        private string location;
        private string name = "Mickey Mouse";
        public string Name { get { return name; } set { name = value; } }
        public string Location
        {get {return location;}
        set{location =value;}

    }
}

    class Program
    {
        public static double Add(double a, double b=3, double c = 6)
        {
            return a + b + c;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            user bob = new user();
            bob.Location = "Disneyland";
            Console.WriteLine($"Name: {bob.Name} Location: {bob.Location}");
            Console.WriteLine($"{Add(1,2.293)}, {Add(1.323)}");
        }
    }
}
