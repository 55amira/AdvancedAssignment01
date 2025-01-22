using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Healper/*<T>*/
    {
        public static void  SWAP<T>(ref T X, ref T Y)
        {
            T temp;
            temp = X;
            X = Y;
            Y = temp;
        }

        public static void Print <T>( T data)
        {
            Console.WriteLine(data);
        }

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
