using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace sorting_algorithms
{
    class Program
    {
        static int[] generateNumbers()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            return numbers;
        }
        static void bubbleSort(int[] unsortedArray)
        {
            int swapCounter = 0;
            int[] sortedArray = new int[unsortedArray.Length];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                sortedArray[i] = unsortedArray[i];
            }
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < sortedArray.Length - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        int temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temp;
                        swapCounter++;
                    }
                }
            }
            Console.WriteLine("Here is the ordered list using a bubble sort: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i]+ " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("It took " + swapCounter + " swaps to sort the array.");
        }
        static void mergeSort(int[] unsortedArray)
        {
            int[] sortedArray = new int[unsortedArray.Length];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                sortedArray[i] = unsortedArray[i];
            }
            int[] tempArray = new int[sortedArray.Length];
            int tempArrayIndex = 0;
            int leftIndex = 0;
            int rightIndex = sortedArray.Length / 2;
            while (leftIndex < sortedArray.Length / 2 && rightIndex < sortedArray.Length)
            {
                if (sortedArray[leftIndex] < sortedArray[rightIndex])
                {
                    tempArray[tempArrayIndex] = sortedArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    tempArray[tempArrayIndex] = sortedArray[rightIndex];
                    rightIndex++;
                }
                tempArrayIndex++;
            }
            while (leftIndex < sortedArray.Length / 2)
            {
                tempArray[tempArrayIndex] = sortedArray[leftIndex];
                leftIndex++;
                tempArrayIndex++;
            }
            while (rightIndex < sortedArray.Length)
            {
                tempArray[tempArrayIndex] = sortedArray[rightIndex];
                rightIndex++;
                tempArrayIndex++;
            }
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = tempArray[i];
            }
            Console.WriteLine("Here is the ordered list using a merge sort: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void insertionSort(int[] unsortedArray)
        {
            int[] sortedArray = new int[unsortedArray.Length];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                sortedArray[i] = unsortedArray[i];
            }
            int temp;
            for (int i = 1; i < sortedArray.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (sortedArray[j] < sortedArray[j - 1])
                    {
                        temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j - 1];
                        sortedArray[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Here is the ordered list using an insertion sort: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void selectionSort(int[] unsortedArray)
        {
            int[] sortedArray = new int[unsortedArray.Length];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                sortedArray[i] = unsortedArray[i];
            }
            int temp;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] > sortedArray[j])
                    {
                        temp = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Here is the ordered list using a selection sort: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] unsortedArray = generateNumbers();


            Console.WriteLine("Unsorted Array: ");
            foreach (int number in unsortedArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            bubbleSort(unsortedArray);
            mergeSort(unsortedArray);
            insertionSort(unsortedArray);
        }
    }
}