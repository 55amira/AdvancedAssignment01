using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) > 0 && value.CompareTo(Max) < 0;
        }

        public T Length()
        {
            dynamic min = Min;  
            dynamic max = Max;
            return max - min;
        }  
    }
}
