using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms
{
    public class JumpSearch
    {
        private int[] inputArray { get; set; }

        private int searchValue { get; set; }
        private int count { get; set; }
        public JumpSearch()
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
            Console.WriteLine(JumpSearchGivenValue(inputArray, 0, inputArray.Length, value));
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed  " + stopwatch.ElapsedTicks);
            Console.WriteLine("no of iterations to check the given value" + count);


        }

//        Works only sorted arrays.
//The optimal size of a block to be jumped is (√ n). This makes the time complexity of Jump Search O(√ n).
//The time complexity of Jump Search is between Linear Search((O(n) ) and Binary Search(O (Log n) ).
//Binary Search is better than Jump Search, but Jump search has an advantage that we traverse back only once(Binary Search may require up to O(Log n) jumps, consider a situation where the element to be search is the smallest element or smaller than the smallest). So in a systems where jumping back is costly, we use Jump Search.

        private int JumpSearchGivenValue(int[] inputArray, int v1, int v2, int value)
        {
            // Finding block size to be jumped 
            int step = (int)Math.Floor(Math.Sqrt(v2));
            // Finding the block where element is 
            // present (if it is present) 
            int prev = 0;


            while (inputArray[Math.Min(step, v2) - 1] < value)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(v2));
                if (prev >= v2)
                    return -1;
            }
            // Doing a linear search for x in block 
            // beginning with prev.
            while (inputArray[prev] < value)
            {
                prev++;

                // If we reached next block or end of 
                // array, element is not present. 
                if (prev == Math.Min(step, v2))
                    return -1;
            }

            // If element is found 
            if (inputArray[prev] == value)
                return prev;

            return -1;
        }
    }
}
