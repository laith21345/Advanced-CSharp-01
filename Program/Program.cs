using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Linq;
using System;
using System.Drawing;

namespace Program
{
    internal class Program
    {
        //بسم الله الرحمن الرحيم
        // Advanced C# 
        //Assignment 01
        static void Main(string[] args)
        {

            #region Q1
            //1.Create a generic Range <T> class that represents a range of values from a minimum value to
            //  a maximum value.
            //The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            //Requirements:
            //●	Create a generic class named Range<T> where T represents the type of values.
            //●	Implement a constructor that takes the minimum and maximum values to define the range.
            //●	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            //●	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            //●	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            #endregion

            #region Q2
            //2. You are given an ArrayList containing a sequence of elements.
            //   try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            //   without using the built-in Reverse.Implement a function that takes the ArrayList
            //   as input and modifies it to have the reversed order of elements.

            //int[] myArr = new int[5];

            //int startPointer = 0,
            //    endPointer = myArr.Length - 1;

            //while (startPointer < endPointer)
            //{
            //    Helper<int>.Swap(ref myArr[startPointer], ref myArr[endPointer]); 

            //    startPointer++;
            //    endPointer--;
            //}

            #endregion

            #region Q3
            //3. You are given a list of integers.
            //   Your task is to find and return a new list containing only the even numbers
            //   from the given list.

            //int[] myArr = new int[5];
            //int[] evenNumbersInMyArr = new int[myArr.Length];

            //for (int i = 0 ,k = 0; i < myArr.Length; i++)
            //{
            //    if (myArr[i] % 2 == 0)
            //    {
            //        evenNumbersInMyArr[i] = myArr[k];
            //        k++;
            //    }
            //}
            #endregion

            #region Q4
            //4. implement a custom list called FixedSizeList<T> with a predetermined capacity.
            //   This list should not allow more elements than its capacity and should provide
            //   clear messages if one tries to exceed it or access invalid indices.
            //Requirements:
            //●	Create a generic class named FixedSizeList<T>.
            //●	Implement a constructor that takes the fixed capacity of the list as a
            //●	parameter.
            //●	Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //●	Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices. 
            
            #endregion

            #region Q5
            //5.Given a string, find the first non - repeated character in it and return its index.
            //If there is no such character, return 
            //Hint: you can use dictionary 
            #endregion

        }
    }
}
