using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
           X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"(X = {X} , Y = {Y})";
        }

        //public int CompareTo(object? obj)
        //{
        //    Point p = (Point)obj;

        //    if(X==p.X)return Y.CompareTo(p.X);

        //    return X.CompareTo(p.X);
        //}

        //public int CompareTo(object? obj)
        //{
        //    if(obj is not null)
        //    {
        //        if (obj is Point P)
        //        {
        //            //Point p = (Point)obj;

        //            if (X == P.X) return Y.CompareTo(P.X);

        //            return X.CompareTo(P.X);

        //        }

        //    }
        //    return -1 ;

        //}

        public int CompareTo(object? obj)
        {
            Point P = obj as Point;

            if (obj is not null)
            {

                    if (X == P.X) return Y.CompareTo(P.X);

                    return X.CompareTo(P.X);

            }
            return -1;

        }
    }
}
