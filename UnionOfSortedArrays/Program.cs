using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionOfSortedArrays
{
    internal class Program
    {
        private static void UnionOfSortedArraysUsingSortedSet(int[] arr1, int[] arr2)
        {
            var sortedSet = new SortedSet<int>();
            foreach(int i in arr1)
                sortedSet.Add(i);
            foreach(int i in arr2)
                sortedSet.Add(i);
            Console.WriteLine("After Union the count of elements becomes " + sortedSet.Count);
        }

        private static void UnionOfSortedArraysUsingHashSet(int[] arr1, int[] arr2)
        {
            var hashSet = new HashSet<int>();
            foreach(int i in arr1)
                hashSet.Add(i);
            foreach(int i in arr2)
                hashSet.Add(i);
            Console.WriteLine("After Union the count of elements becomes " + hashSet.Count);
        }

        private static void UsingUnionMethod(int[] arr1, int[] arr2)
        {
            var union = arr1.Union(arr2);
            Console.WriteLine("Union is " + union.Count());
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 85, 25, 1, 32, 54, 6 };
            int[] arr2 = { 85, 2 };

            UnionOfSortedArraysUsingSortedSet(arr1, arr2);
            UnionOfSortedArraysUsingHashSet(arr1, arr2);
            UsingUnionMethod(arr1, arr2);
        }
    }
}
