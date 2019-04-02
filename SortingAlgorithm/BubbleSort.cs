using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
   public  class BubbleSort
    {
        private static int[] inputArray { get; set; }
        private static Random random = new Random();

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public BubbleSort()
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

           // BubbleSortingApproach();
            PerfBubbleSortingApproach();
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }


        }

        private void BubbleSortingApproach()
        {
            int length = inputArray.Length;
           
            for (int i = 0; i < length; i++)
            {

                for (int j = 0; j < length-i-1; j++)
                {
                    if (inputArray[j]>inputArray[j+1])
                    {
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[j+1];
                        inputArray[j+1] = temp;
                       
                    }
                }

               

            }
        }

        private void PerfBubbleSortingApproach()
        {
            int length = inputArray.Length;
            bool swap = false;
            for (int i = 0; i < length; i++)
            {

                for (int j = 0; j < length - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                        swap = true;
                    }
                }

                if (!swap)
                    break;

            }
        }

    }
}
