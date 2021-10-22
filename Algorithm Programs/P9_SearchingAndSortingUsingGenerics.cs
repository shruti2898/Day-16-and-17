using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class P9_SearchingAndSortingUsingGenerics
    {   
        public void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i< arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public int BinarySearch<T>(T[] arr, T left, T right, T value) where T : IComparable<T>
        {
                      
            if (left.CompareTo(right) <= 0)
            {
                T mid = left + ((dynamic)right - left) / 2;
                int m = (dynamic)mid;
                if (arr[m].Equals(value))
                {
                    return m;
                }
                else if (arr[m].CompareTo(value) > 0)
                {
                    return BinarySearch(arr, left, (dynamic)mid - 1, value);        // left sub array
                }
                else
                {
                    return BinarySearch(arr, (dynamic)mid + 1, right, value);      // right sub array
                }
            }

            return -1;
        }

        public void printArray<T>(T[] arr)
        {
            foreach (T element in arr)
            {
                Console.Write(element + " ");
            }
        }

        public void SearchingAndSorting()
        {
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("\nEnter array elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] temp = arr;

            Console.WriteLine("\n\n");

           char ch;
            do
            {
                Console.Clear();
                Console.Write("Select an option: \n1. Bubble Sort \n2. Binary Search\nOption:  ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Array before sorting: ");
                    printArray<int>(arr);

                    BubbleSort<int>(arr);

                    Console.WriteLine("\n\nArray after sorting: ");
                    printArray<int>(arr);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    int left = 0;
                    int right = arr.Length - 1;

                    Console.WriteLine("Array: ");
                    printArray<int>(arr);

                    Console.Write("\n\nEnter value to be searched: ");
                    int value = Convert.ToInt32(Console.ReadLine());

                    int index =BinarySearch<int>(arr, left, right,value);
                    Console.WriteLine((index == -1) ? "\nElement not found" : "\nElement found at position " + (index + 1));
                }
                else
                {
                    Console.WriteLine("\nInvalid Option");
                }

                Console.Write("\n\nDo you want to continue? (y/n)      ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch=='y');
            
        }       

    }
}
