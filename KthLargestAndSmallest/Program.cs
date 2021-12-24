using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthLargestAndSmallest
{
    internal class Program
    {
        private static void kthSmallestAndLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            Console.WriteLine("Kth smallest = " + nums[k - 1] + ", kth largest = " + nums[nums.Length - k]);
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 6, 8, 4, 9 };
            int k = 3;
            kthSmallestAndLargest(nums, k);
        }
    }
}
