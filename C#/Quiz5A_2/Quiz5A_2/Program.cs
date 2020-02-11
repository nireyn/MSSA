using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5A_2
{
    class Program
    {
        public enum Color { red, white, blue };
        static void Main(string[] args)
        {
            object myColor;
            Console.WriteLine("Enter a value: 0 is red, 1 is white, and 2 is blue.");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    myColor = Color.red;
                    Console.WriteLine($"Switch is 0, color is {myColor}.");
                    break;
                case 1:
                    myColor = Color.white;
                    Console.WriteLine($"Switch is 1, color is {myColor}.");
                    break;
                case 2:
                    myColor = Color.blue;
                    Console.WriteLine($"Switch is 2, color is {myColor}.");
                    break;
                default:
                    Console.WriteLine("Wrong color.");
                    break;
            }
        }
    }
}
