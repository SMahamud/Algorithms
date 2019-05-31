using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
   public  class BubbleSort
    {
        private static int[] inputArray { get; set; }



        public static int[] perfint { get; set; }
        private static Random random = new Random();

        public static int count { get; set; }

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public BubbleSort()
        {
            inputArray = new int[120];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(RandomNumber(2));
            }
            perfint = new int[120];
            Array.Copy(inputArray,perfint,inputArray.Length);
            //Console.WriteLine("Unsorted Array");
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    Console.WriteLine(inputArray[i]);
            //}
            //Console.WriteLine("--------------------------------------------------------------------------");

            BubbleSortingApproach();
            Console.WriteLine( "Number of iterations took to sort data" +count);
            //Console.WriteLine("Sorted Array");
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    Console.WriteLine(inputArray[i]);
            //}

            //inputArray = new int[50];
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    inputArray[i] = Convert.ToInt32(RandomNumber(2));
            //}

            //Console.WriteLine("Unsorted Array");
            //for (int i = 0; i < perfint.Length; i++)
            //{
            //    Console.WriteLine(perfint[i]);
            //}

            Console.WriteLine("--------------------------------------------------------------------------");
            PerfBubbleSortingApproach();

            Console.WriteLine("Number of iterations took to sort data" + count);
            Console.WriteLine("Sorted Array");
            //for (int i = 0; i < perfint.Length; i++)
            //{
            //    Console.WriteLine(perfint[i]);
            //}



        }

        private void BubbleSortingApproach()
        {
            count = 0;
            int length = inputArray.Length;
           
            for (int i = 0; i < length; i++)
            {

                for (int j = 0; j < length-i-1; j++)
                {
                    count++;
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
            count = 0;
            int length = perfint.Length;
            bool swap = false;
            for (int i = 0; i < length; i++)
            {

                for (int j = 0; j < length - i - 1; j++)
                {
                    count++;
                    if (perfint[j] > perfint[j + 1])
                    {
                        int temp = perfint[j];
                        perfint[j] = perfint[j + 1];
                        perfint[j + 1] = temp;
                        swap = true;
                    }
                }

                if (!swap)
                    break;

            }
        }

    }
}
