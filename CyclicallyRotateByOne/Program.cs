using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicallyRotateByOne
{
    internal class Program
    {
        private static void CyclicallyRotate(int[] arr, int n)
        {
            int last = arr[arr.Length - 1];
            int i = n - 1;
            while(i > 0)
            {
                arr[i] = arr[i - 1];
                i--;
            }
            arr[0] = last; 
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            CyclicallyRotate(arr, arr.Length);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
