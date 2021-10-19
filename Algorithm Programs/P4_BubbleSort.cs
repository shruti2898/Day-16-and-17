using System;

namespace DataStructure
{
    class P4_BubbleSort
    {
        public void bubbleSort()
        {
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("\nEnter array elements: ");
            for(int i =0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nArray before sorting: ");
            printArray(arr, n);

            for(int i = 0; i < n-1; i++)           
            {
                for(int j=0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])         
                    {                                
                        int temp = arr[j];               
                        arr[j] = arr[j + 1]; 
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nArray after sorting: ");
            printArray(arr, n);
        }

        public void printArray(int[] arr, int n)
        {           
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
