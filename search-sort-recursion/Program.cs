using System;

namespace search_sort_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgo sorting = new SortingAlgo();
            var unsortedArr = new int[] {9, 10, 1, 1009, 200, 0, 1};


            // sorting.BubbleSort(unsortedArr);

            var mergeSortResult = sorting.MergeSort(unsortedArr);

            for (int i = 0; i < mergeSortResult.Length; i++)
            {
                Console.Write(mergeSortResult[i] + " ");
            }
           // Console.WriteLine("done");
        }
    }
}
