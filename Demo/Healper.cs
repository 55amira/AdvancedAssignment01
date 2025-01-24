using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Healper/*<T>*/
    {
        public static int LinnerSearch<T>(T[] Arr, T value,IEqualityComparer<T> equalityComparer)
        {

            if (Arr?.Length > 0)
            {

                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(Arr[i],value))
                        return i;

                }


            }

            return -1;
        }
        public static void BubbleSort<T>(T[] Arr) where T : IComparable
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo( Arr[j + 1])>0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }

        }
        public static void BubbleSort(int[] Arr)
        {
            if(Arr?.Length>0)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0;j<Arr.Length-i-1; j++)
                    {
                        if (Arr[j] > Arr[j+1])
                        {
                            SWAP(ref Arr[j], ref Arr[j+1]); 
                        }
                    }
                }
            }

        }
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T temp;
            temp = X;
            X = Y;
            Y = temp;
        }

        public static void Print<T>(T[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"{Numbers[i]} ");
            }
        }

        #region Generic EX : LinnerSearch
        public static int LinnerSearch<T>(T[] Arr, T value)
        {

            if (Arr?.Length > 0)
            {

                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(value))
                        return i;

                }


            }

            return -1;
        }
        #endregion

        #region Non Gereric Linnser Method
        //public static int LinnerSearch(int[] Arr, int value)
        //{

        //    if (Arr?.Length >0) 
        //    {

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == value)
        //                return i;

        //        }


        //    }

        //    return -1;
        //} 
        #endregion

        #region Generic SWAP
        //public static void  SWAP<T>(ref T X, ref T Y)
        //{
        //    T temp;
        //    temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        //public static void Print <T>( T data)
        //{
        //    Console.WriteLine(data);
        //} 
        #endregion

        #region Non Genaric
        //    public static void SWAP(ref int X ,ref int Y)
        //    {
        //        int temp;
        //        temp = X;
        //        X = Y;
        //        Y = temp;
        //    }

        //    public static void SWAP(ref double X, ref double Y)
        //    {
        //        double temp;
        //        temp = X;
        //        X = Y;
        //        Y = temp;
        //    }

        //    public static void SWAP(ref Point X, ref Point Y)
        //    {
        //        Point temp;
        //        temp = X;
        //        X = Y;
        //        Y = temp;
        //    } 
        #endregion

    }
}
