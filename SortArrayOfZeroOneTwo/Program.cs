using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfZeroOneTwo
{
    internal class Program
    {
        private static void SortArray(int[] a, int n)
        {
            int countZero = 0, countOne = 0, countTwo = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0)
                    countZero++;
                else if (a[i] == 1)
                    countOne++;
                else
                    countTwo++;
            }
            for (int i = 0; i < n; i++)
            {
                if (countZero != 0)
                {
                    a[i] = 0;
                    countZero--;
                }
                else if (countOne != 0)
                {
                    a[i] = 1;
                    countOne--;
                }
                else if (countTwo != 0)
                {
                    a[i] = 2;
                    countTwo--;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] num = { 0, 2, 1, 2, 0 };
            SortArray(num, 5);
            foreach (int i in num)
                Console.Write(" " + i);
        }
    }
}
