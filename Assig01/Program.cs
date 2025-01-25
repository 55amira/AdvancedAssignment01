using System;

namespace Assig01
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm And implement the code of this optimised bubble sort algorithm

            //int[] Arr = { 4, 14, 8, 5, 10, 55 };
            //Q1.Print(Arr);
            //Console.WriteLine();
            //Q1.BubbleSort(Arr);
            //Q1.Print(Arr); 
            #endregion



            #region Q2 create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.Requirements:Create a generic class named Range<T> where T represents the type of values.Implement a constructor that takes the minimum and maximum values to define the range.Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            //Range<int> range = new Range<int>(1, 10);
            //bool isinrange = range.IsInRange(11);
            //Console.WriteLine(isinrange);
            //int length = range.Length();
            //Console.WriteLine(length);

            #endregion


            #region Q3 You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //int[] Arr = { 1, 2, 3, 4, 5 };

            //Q3.Reverse(Arr);
            //Q3.Print(Arr); 
            #endregion



            #region Q4 You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> NewList = new List<int>();
            //foreach (int n in List)
            //{
            //    if (n % 2== 0)
            //    {
            //        NewList.Add(n);
            //    }

            //}

            //foreach (int n in NewList)
            //{
            //    Console.Write($"{n} ");
            //} 
            #endregion



            #region Q5 implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.Requirements:Create a generic class named FixedSizeList<T>.Implement a constructor that takes the fixed capacity of the list as aparameter.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            // FixedSizeList<int> Arr = new FixedSizeList<int> (5);
            // Arr.Add (1);
            // Arr.Add (2);    
            // Arr.Add (3);    
            // Arr.Add (4);
            // //Arr.Add (5);

            //Console.WriteLine(Arr.Get(1));
            // Arr.Add (55);
            // Console.WriteLine(Arr.Get(4)); 
            #endregion

            #region Q6 Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary

            //string s = "amira";

            //Console.WriteLine(Q6.FindTheFirstNonRepeatedCharacter(s)); 
            #endregion


        }
    }
}


