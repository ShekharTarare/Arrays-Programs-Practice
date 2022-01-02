using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadanesAlgorithm
{
    internal class Program
    {
        private static void KadaneAlgo(int[] arr, int n)
        {
            int sum = 0, max = arr[0];
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
                if (sum < 0)
                    sum = 0;
                if(max < sum)
                    max = sum;
            }
            Console.WriteLine("The contiguous sub array which has maximum sum is " + max);
        }

        private static void KadaneAlgoHandleNegative(int[] arr, int n)
        {
            int sum = 0, max = arr[0];
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
                if (sum < arr[i]) //comparing the array element and storing it if it is lesser
                    sum = arr[i];
                if (max < sum)
                    max = sum;
            }
            Console.WriteLine("The contiguous sub array which has maximum sum is " + max);
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, -2, 5 };
            int[] arr2 = { -1, -2, -3, -4 };
            KadaneAlgo(arr1, 5);
            KadaneAlgoHandleNegative(arr2, 4);
        }
    }
}
