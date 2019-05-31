using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
    public class HeapSort
    {
        private static int[] inputArray { get; set; }

        private static Random random = new Random();

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public HeapSort()
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

            HeapSortingApproach();

            Console.WriteLine("Sorted Array");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }



            Console.WriteLine("--------------------------------------------------------------------------");

        }

        private void HeapSortingApproach()
        {
            int n = inputArray.Length;

            // Build heap (rearrange array) 
            // The function heapSort() first converts the given elements into a heap.
            //This is done by using the for loop and calling the function heapify() for all the non - leaf elements of the heap.
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(inputArray, n, i);

            // One by one extract an element from heap 

            //After the heap is created, a for loop is used to remove the root element of the heap i.e. the largest element. 
            //It is replaced by the rightmost leaf element and then heapify() is called again to reestablish the heap.
            
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = inputArray[0];
                inputArray[0] = inputArray[i];
                inputArray[i] = temp;

                // call max heapify on the reduced heap 
                heapify(inputArray, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 

        //The function heapify() creates a heap structure by arranging the elements as required. This process starts from the element at index i for this is considered the root element for the heapify() function. This can be seen in the following code snippet.

        
       private void heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree 
                heapify(arr, n, largest);
            }
        }
    }
}
