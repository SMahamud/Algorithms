using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms
{
    public class BinarySearch
    {
        private int[] inputArray { get; set; }

        private int searchValue { get; set; }
        private int count { get; set; }

        public BinarySearch()
        {
            inputArray = new int[10000001];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = i;
            }

            Console.Write("-----------------------------------------\n");
            Console.Write("\n\nSearch the given number in above array using Binary Search  :\n");

            int value = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BinarySearchGivenValue(inputArray,0,inputArray.Length-1, value);
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed  " + stopwatch.ElapsedTicks);
            Console.WriteLine("no of iterations to check the given value" + count);

            


        }

        private int BinarySearchGivenValue(int[] inputArray, int startindex, int endIndex, int value)
        {
            count++;
            if (endIndex >= startindex)
            {
                int mid = (startindex + endIndex) / 2;

                if (inputArray[mid] == value)
                {
                    Console.WriteLine("Element is present at index " + mid);
                    return mid;
                }
                else if (inputArray[mid] > value)
                {
                    return BinarySearchGivenValue(inputArray, startindex, mid - 1, value);
                }
                else if (inputArray[mid] < value)
                {
                    return BinarySearchGivenValue(inputArray, mid + 1, endIndex, value);
                }
            }

            Console.WriteLine("Element is not present in array");

            return -1;
            
        }
    }
}
