using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class P5_MergeSort
    {
        public void mergeSort()
        {
            string[] strArr = { "white", "black", "blue", "green", "red", "orange", "brown", "yellow", "pink", "magenta" };

            Console.WriteLine("Array before sorting");
            printArray(strArr);


            sortingArray(strArr, 0, strArr.Length - 1);

            Console.WriteLine("\n\nArray after sorting");
            printArray(strArr);
        }

        void mergeArray(string[] arr, int left,int mid, int right)
        {
            int L = mid - left + 1;     // Size of left subarray
            int R = right - mid;        // Size of right subarray

            string[] leftArr = new string[L];
            string[] rightArr = new string[R];

            int i, j;
            for (i = 0; i < L; ++i)
            {
                leftArr[i] = arr[left + i];
            }
               
            for (j = 0; j < R; ++j)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;

            int k = left;
            while (i < L && j < R)
            {
                if (leftArr[i].CompareTo(rightArr[j]) <= 0)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < L)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < R)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

        void sortingArray(string[] arr , int left , int right)
        { 
            if(left < right)
            {
                int mid = left + (right - left) / 2;

                sortingArray(arr, left, mid);

                sortingArray(arr, mid + 1, right);

                mergeArray(arr, left, mid, right);
            }

        }
        void printArray(string[] arr)
        {
            foreach(var str in arr)
            {
                Console.Write(str+"  ");
            }
        }
    }
}
