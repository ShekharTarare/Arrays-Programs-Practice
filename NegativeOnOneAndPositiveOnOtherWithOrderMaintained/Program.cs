using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeOnOneAndPositiveOnOtherWithOrderMaintained
{
    internal class Program
    {
        private static void ArrangeArray(int[] num, int n)
        {
            int[] arr = new int[n];
            int first = 0;
            int last = n - 1;
            int j = 0, k = n - 1;
            while(first <= n && last >= 0)
            {
                if (num[first] < 0)
                    arr[j++] = num[first];
                
                if (num[last] > 0)
                    arr[k--] = num[last];                    
                
                last--;
                first++;
            }
            foreach (int i in arr)
                Console.Write(" " + i);
        }

        static void Main(string[] args)
        {
            int[] num = { 12, 11, -13, -5, 6, -7, 5, -3, -6 };
            ArrangeArray(num, 9);
        }
    }
}
