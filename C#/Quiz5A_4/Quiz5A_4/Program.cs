using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5A_4
{
    public static class Author
    {
        public static string Authorname = "Steinbeck";
        public static string Bookname = "grapes of wrath";
        public static int numPages = 464;

        public static void Details()
        {
            Console.WriteLine($"Book: {Bookname}, Author: {Authorname}, Number of pages: {numPages}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Author.Details();
        }
    }
}
