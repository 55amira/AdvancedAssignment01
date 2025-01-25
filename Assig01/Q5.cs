using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01
{
    public class FixedSizeList<T>
    {
        public T[] Arr { get; set; }
        public int currentIndex { get; set; }

        public FixedSizeList(int capacity)
        {
            Arr = new T[capacity];
            currentIndex = 0;
        }

        public void Add(T item)
        {
            if (currentIndex > Arr.Length)
            {
                Console.WriteLine("Cannot add  item. The Array is full");
            }

            Arr[currentIndex] = item;
            currentIndex++;
        }

        public T Get(int index)
        {
            if (index < 0 || index > Arr.Length)
            {
                Console.WriteLine("Index is out of range.");
            }

            return Arr[index];
        }
    }

}