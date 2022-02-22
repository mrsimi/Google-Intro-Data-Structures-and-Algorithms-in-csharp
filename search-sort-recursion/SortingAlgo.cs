using System;

namespace search_sort_recursion
{
    public class SortingAlgo
    {
        public void BubbleSort(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                for(int j=0; j< arr.Length -i-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }


        public int[] MergeSort(int[] array)
        {
             int[] left;
            int[] right;
            int[] result = new int[array.Length];  
            if (array.Length <= 1)
                return array;  

            int midPoint = array.Length / 2;  
            left = new int[midPoint];
  
            if (array.Length % 2 == 0)
                right = new int[midPoint];  
            else
                right = new int[midPoint + 1]; 

            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];  

            int x = 0;

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }  

            
            left = MergeSort(left);
            
            right = MergeSort(right);
            
            result = Merge(left, right);  
            return result;
        }

        private int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;  
           
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                
                if (indexLeft < left.Length && indexRight < right.Length)  
                {  
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }  
            }
            return result;
        }
    }
}