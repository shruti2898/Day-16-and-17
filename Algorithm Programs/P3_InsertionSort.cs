using System;
using System.IO;

namespace DataStructure
{
    class P3_InsertionSort
    {      
        public void insertionSort()
        {
            // Input text file path
            string file = @"C:\Users\Mehta\Desktop\Bridgelab\DataStructurePrograms\DataStructure\input.txt";

            // Reading comma-separated values from text file
            string str = File.ReadAllText(file);

            // Converting content of text file into string array
            String[] strArray = str.Split(',');

            Console.Write("Array before sorting: \n");
            printArray(strArray);

            //Insertion sort
            sorting(strArray);

            Console.Write("\nArray after sorting: \n");
            printArray(strArray);
       }

        void sorting(string[] strArray)
        {          
            for (int i = 1; i < strArray.Length; ++i)
            {
                string key = strArray[i];
                int j = i - 1;
                while (j >= 0 && strArray[j].CompareTo(key)>0)
                {
                    strArray[j + 1] = strArray[j];
                    j = j - 1;
                }
                strArray[j + 1] = key;
            }
        }

        void printArray(string[] strArray)
        {
            for (int i = 0; i < strArray.Length; ++i)
            {
                Console.Write(strArray[i] + "\n");
            }
        }        
    }
}
