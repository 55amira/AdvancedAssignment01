using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Healper/*<T>*/
    {


        #region Generic EX : LinnerSearch
        //public static int LinnerSearch<T>(T[] Arr, T value)
        //{

        //    if (Arr?.Length > 0)
        //    {

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals( value))
        //                return i;

        //        }


        //    }

        //    return -1;
        //} 
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
