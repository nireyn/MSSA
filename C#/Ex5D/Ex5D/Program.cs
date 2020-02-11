using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5D
{
    class Program
    {
        public static void SortMe(int[] toSort)
        {
            for(int i = 0; i<toSort.Length;i++)
            {
                for(int j = i; j < toSort.Length; j++)
                {
                    int a = toSort[i];
                    int b = toSort[j];
                    if (b < a)
                    {
                        toSort[i] = b;
                        toSort[j] = a;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9,5, -3};
            SortMe(arr);
            Console.Write("Here is my sorted array: ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
