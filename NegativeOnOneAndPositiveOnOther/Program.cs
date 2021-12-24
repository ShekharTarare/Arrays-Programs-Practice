using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeOnOneAndPositiveOnOther
{
    internal class Program
    {
        private static void ArrangeArray(int[] num, int n)
        {
            int first = 0;
            int last = n - 1;
            while(first < last)
            {
                if (num[first] < 0)
                {
                    first++;
                }
                else
                {
                    if (num[last] > 0)
                    {
                        last--;
                    }
                    else
                    {
                        int temp;
                        temp = num[first];
                        num[first] = num[last];
                        num[last] = temp;
                        first++; last--;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] num = { -12, 11, -13, -5, 6, -7, 5, -3, -6 };
            ArrangeArray(num, 9);
            foreach (int i in num)
                Console.Write(" " + i);
        }
    }
}
