using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LinearSearch
    {
        private int[] inputArray { get; set; }

        private int searchValue { get; set; }

        private int count { get; set; }
        public LinearSearch()
        {
            inputArray = new int[10000001];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = i;
            }

            Console.Write("-----------------------------------------\n");
            Console.Write("\n\nSearch the given number in above array using Linear search :\n");
            int value = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SearchGivenValue(inputArray, value);
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed  "+stopwatch.ElapsedTicks);

            Console.WriteLine("no of iterations to check the given value" + count);


        }
        public int SearchGivenValue(int[]input,int value )
        {

            for (int i = 0; i < input.Length; i++)
            {
                count++;
                if (input[i] == value)
                {
                    Console.WriteLine("Element is present at index " + i);
                    return i;
                }
            }
            Console.WriteLine("Element is not present in array");
            return -1;

        }
    }
}
