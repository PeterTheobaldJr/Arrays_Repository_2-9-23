/* Author: Peter Theobald
  Date: 2/9/23
Comments: This C# Console applicaion code demonstrates the use of arrays.
 */
using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the size of the array
            int n = 25;

            // Initialize an array of size n to store the Fibonacci numbers
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            // Generate the Fibonacci sequence
            for (int i = 2; i < n; i++)
            {
                // The current number is the sum of the two previous numbers
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            // Display the Fibonacci sequence
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
            Console.ReadKey();
        }
    }
}