// Author: Jonathan Spalding
// Assignment: lab 24
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 4/5/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        // this is the date to be sorted
        int[] theData = { 45, 12, 23, 34 };

        // sort the array in ascending order
        // print out lots of messages so we can see the sort work
        for (int j = 0; j < theData.Length - 1; j++)  // index for outer loop is j
        {
            WriteLine("Iteration {0} for the outer loop", j);
            for (int i = 0; i < theData.Length - 1; i++)  // index for inner loop is i
            {
                WriteLine("\nIteration {0} for the inner loop", i);
                if (theData[i] < theData[i + 1])
                    Swap(ref theData[i], ref theData[i + 1]);
            }
        }

        // print out the sorted array
        WriteLine("\n\n*****  The sorted array is: *****");
        for (int i = 0; i < theData.Length; i++)
        {
            Write($"{theData[i] } ");
        }
        WriteLine();
        ReadKey(true);
    }

    // method prototype for the swap routine
    // parameters: two integers, passed by reference
    // routines: none
    // The two integer values are swapped
    // ---------------------------------------------------
    static void Swap(ref int a, ref int b)
    {
        WriteLine($"Swapping {a} and {b}");
        int temp = a;
        a = b;
        b = temp;
    }
}