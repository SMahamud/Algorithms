using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
    public  class QuickSort
    {
        private static int[] inputArray { get; set; }

        private static Random random = new Random();

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public QuickSort()
        {
            inputArray = new int[6];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(RandomNumber(2));
            }

            Console.WriteLine("Unsorted Array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------------");

            QuickSortingApproach(inputArray, 0, inputArray.Length-1);

            Console.WriteLine("Sorted Array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }



            Console.WriteLine("--------------------------------------------------------------------------");

        }

        private void QuickSortingApproach(int [] arr ,int low, int high)
        {

        } 
        
    }
}
