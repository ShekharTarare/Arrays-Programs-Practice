using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAndMininumOfAnArray
{
    internal class Program
    {
        private static void MinAndMaxOfAnArr(int[] arr)
        {
            int min = arr[0], max = arr[0];
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (min > arr[i])
                        min = arr[i];
                    else
                    {
                        if (max < arr[i])
                            max = arr[i];
                    }
                }
            }
            Console.WriteLine("Minimum = " + min + ", Maximum = " + max);
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 56, 4, 7, 89, 100 };
            MinAndMaxOfAnArr(arr);
        }
    }
}
