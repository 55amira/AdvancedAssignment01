using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01
{
    internal static class Q1
    {
        public static void Swap (ref int  X, ref int  Y)
        {
            int  temp;
            temp = X;
            X = Y;
            Y = temp;
        }
        
        public static void BubbleSort(int [] Arr)
        {
            bool Sawped=false;

           for (int i = 0; i < Arr.Length; i++)
           {
                Sawped = false;

                for (int j = 0;j < Arr.Length - i - 1 ; j++)
                {
                    if (Arr[j] > Arr[j+1])
                    {
                        Swap(ref Arr[j], ref Arr[j + 1]);
                        Sawped = true;
                    }
                }

                if (!Sawped)
                    break;

           }

           
        }

        public static void Print(int[] Arr)
        {
            for (int i = 0;i < Arr.Length;i++)
            {
                Console.Write($"{Arr[i]} ");
            }
        }
    }
}
