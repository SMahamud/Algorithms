using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
    public class SelectionSort
    {
        private static int[] inputArray { get; set; }
        private static Random random = new Random();

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public SelectionSort()
        {
            inputArray = new int[5];
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

            SelectionSortingApproach();
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }



        }

        public void SelectionSortingApproach()
        {
            int length = inputArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int min_index = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (inputArray[j] < inputArray[min_index])

                        min_index = j;
                }
                int temp = inputArray[min_index];
                inputArray[min_index] = inputArray[i];
                inputArray[i] = temp;

            }
        }
    }
}

