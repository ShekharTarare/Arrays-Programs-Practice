using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnInteger
{
    internal class Program
    {
        private static int UsingBuiltInMethod(int num)
        {
            char[] st = num.ToString().ToCharArray();
            Array.Reverse(st);
            return int.Parse(new string(st));
        }

        private static int WithoutBuiltIn(int num)
        {
            int rev_num = 0;
            while(num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num /= 10;
            }
            return rev_num;
        }
        private static int WithoutBuiltInButByConversion(int num)
        {
            int i, j;
            char[] str = num.ToString().ToCharArray();

            i = 0;
            j = str.Length - 1;
            while(i < j)
            {
                char temp;
                temp = str[i];
                str[i] = str[j];
                str[j] = temp;
                i++;
                j--;
            }
            return int.Parse(new string(str));
        }
        static void Main(string[] args)
        {
            int num = 5678;
            Console.WriteLine("Reverse is " + UsingBuiltInMethod(num));
            Console.WriteLine("Reverse is " + WithoutBuiltInButByConversion(num));
            Console.WriteLine("Reverse is " + WithoutBuiltIn(num));
        }
    }
}
