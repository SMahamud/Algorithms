using System;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //LinearSearch O(n)
                //  LinearSearch linearSearch = new LinearSearch();

                //The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n).
                //  BinarySearch binarySearch = new BinarySearch();


                //The basic idea is to check fewer elements (than linear search) by jumping ahead by fixed steps or skipping some elements in place of searching all elements.
                JumpSearch jumpSearch = new JumpSearch();

                Console.WriteLine("Hello World!");
            }
            //}
        }
    }
}
