/*
 * CSC205 Week 4 Programmming Assignment - Problem #2
/* useful links:
 * https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file
 * https://dotnetcoretutorials.com/2020/05/10/basic-sorting-algorithms-in-c/
 * https://medium.com/engineering-hub/https-medium-com-engineering-hub-sorting-algorithms-in-csharp-and-java-4615f6f87696
 */

using System;
using System.IO;
using System.Diagnostics;

namespace CSC205Week04
{
    class Program
    {
        static void Main3(string[] args)
        {
            string fileName = "numbers.txt";
            Stopwatch stopwatch = new Stopwatch();
            Method01(fileName, 1000, 1, 1001);

            // Read all lines from the file into a string array
            string[] lines = File.ReadAllLines(fileName);

            // Convert the string array to an integer array
            int[] values = new int[lines.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(lines[i]);
            }

            stopwatch.Start();
            Console.WriteLine("starting ... ");

            // Sort the array using Method02
            Method02(values);
            Console.WriteLine("done! ... ");

            stopwatch.Stop();
            Console.WriteLine("time measured: {0} ms", stopwatch.ElapsedMilliseconds);

            // Print the sorted values
            foreach (int value in values)
                Console.Write(value + " ");
            Console.WriteLine();
        }

        // Method01 generates random integers and writes them to a file
        // located at:  (C:\Users\njpet\source\repos\RationalProject\bin\Debug\net8.0)
        static void Method01(string fileName, int total, int lowerRange, int upperRange)
        {
            using (var writer = new StreamWriter(fileName))
            {
                Random r = new Random();
                int number = 0;
                {
                    for (int i = 1; i < total; i++)
                    {
                        number = r.Next(lowerRange, upperRange);
                        writer.WriteLine(number);
                    }
                }
            }
        }

        // Method02 sorts an array using the selection sort algorithm
        static void Method02(int[] arr)
        {
            for (int start = 0; start < arr.Length - 1; start++)
            {
                int posMin = start;
                for (int i = start + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[posMin])
                    {
                        posMin = i;
                    }
                }
                int tmp = arr[start];
                arr[start] = arr[posMin];
                arr[posMin] = tmp;
            }
        }

        /* 
         * 1) Method01 generates a specified number of random integers within a given range and writes them to a file.
         * 2) Method02 implements the selection sort algorithm to sort an array of integers in ascending order.
         * 3) The code sgment reads all lines from the file number.txt, converts each line to an integer, and stores
         * these integers in an array.
         * 4) In my case the file is located at: (C:\Users\njpet\source\repos\RationalProject\bin\Debug\net8.0)
        */

    }
}