using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
    public class Insertion
    {
        private static int[] inputArray { get; set; }
       
        private static Random random = new Random();

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public Insertion()
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

            InsertionSortingApproach();
           
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }

           

            Console.WriteLine("--------------------------------------------------------------------------");
           



        }

        private void InsertionSortingApproach()
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                int j = i - 1;
                int key = inputArray[i];
                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j>=0 && inputArray[j]>key)
                {
                    inputArray[j + 1] = inputArray[j];
                    j--;
                }
                inputArray[j+1] = key;
            }
        }
    }
}
