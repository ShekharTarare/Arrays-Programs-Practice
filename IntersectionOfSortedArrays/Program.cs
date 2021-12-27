using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfSortedArrays
{
    internal class Program
    {
        private static void IntersectionUsingIntersect1(int[] arr1, int[] arr2)
        {
            var intersect = arr1.Intersect(arr2);
            Console.WriteLine("Count of elements " + intersect.Count());
        }
        private static void IntersectionUsingIntersect2(int[] arr1, int[] arr2)
        {
            int p = 0, q = 0;
            while(p < arr1.Length && q < arr2.Length)
            {
                if (arr1[p] > arr2[q])
                    q++;
                else if(arr2[q] > arr1[p])
                    p++;
                else
                {
                    Console.WriteLine(arr1[p]);
                    p++; q++;
                }
            }
        }
        private static void IntersectionUsingIntersect3(int[] arr1, int[] arr2)
        {
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                        Console.WriteLine(arr1[i]);
                }
            }
        }
        private static void IntersectionUsingIntersect4(int[] arr1, int[] arr2)
        {
            HashSet<int> set = new HashSet<int>(arr1);  
            for(int i = 0; i < arr2.Length; i++)
            {
                if (set.Contains(arr2[i]))
                    Console.WriteLine(arr2[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 5, 6 };
            int[] arr2 = { 4, 6, 8, 10 };

            IntersectionUsingIntersect1(arr1, arr2);
            IntersectionUsingIntersect2(arr1, arr2);
            IntersectionUsingIntersect3(arr1, arr2);
            IntersectionUsingIntersect4(arr1, arr2);
        }
    }
}
