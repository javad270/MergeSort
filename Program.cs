using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMergeSort();

            Console.ReadKey();
        }

         private static void TestMergeSort()
        {
            Random r = new Random();

            int[] Numbers = new int[10];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = r.Next(10, 100);
            }

            Console.WriteLine(" Unsorted array: ");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + "  ");
            }

            Console.WriteLine("\nSorted array: ");
            Numbers.DomergeSort();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + "  ");
            }
        }
    }
    
}
