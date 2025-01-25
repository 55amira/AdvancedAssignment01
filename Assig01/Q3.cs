using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01
{
    internal static class Q3
    {
        public static void Swap(ref int X, ref int Y)
        {
            int temp;
            temp = X;
            X = Y;
            Y = temp;
        }

        public static void Reverse(int[] Arr)
        {
            int start = 0; 
            int end = Arr.Length - 1; 

            while (start < end)
            {
                
                Swap(ref Arr[start], ref Arr[end]);

               
                start++;
                end--;
            }
        }

        public static void Print(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"{Arr[i]} ");
            }
        }
    }
}
