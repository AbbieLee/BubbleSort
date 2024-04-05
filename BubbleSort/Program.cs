using System;
using System.Xml.Linq;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 5, 3, 4, 8, 2, 9, 7, 1, 6 };
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Unsorted array:");
            PrintArray(numbers);

            BubbleSortArray(numbers);

            Console.WriteLine("\nSorted array:");
            PrintArray(numbers);
        }

        static void BubbleSortArray(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1]) //if current number is greater than consecutive number
                    {
                        int temp = array[j]; //stores current number in a temporary variable
                        array[j] = array[j + 1]; //next number assigned to the current position
                        array[j + 1] = temp; //temporary variable assigned to the next position
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}