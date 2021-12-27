using System;

namespace MergingTwoSortedArrays
{
    internal class Program
    {
        private static void MergeTwoSortedArrays(int[] arr1, int[] arr2, int m, int n)
        {
            int[] arr3 = new int[m + n];
            int i = 0, j = 0, k = 0;
            
            while(i < m && j < n)
            {
                if(arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else if(arr2[j] < arr1[i])
                    arr3[k++] = arr2[j++];
                else
                    arr3[k++] = arr1[i++];
            }
            while(i < m)
                arr3[k++] = arr1[i++];

            while(j < n)
                arr3[k++] = arr2[j++];

            foreach (int item in arr3)
                Console.Write(item + " ");
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 5, 7, 9 };
            int[] arr2 = { 3, 6, 7, 8 };
            MergeTwoSortedArrays(arr1, arr2, arr1.Length, arr2.Length);
        }
    }
}
