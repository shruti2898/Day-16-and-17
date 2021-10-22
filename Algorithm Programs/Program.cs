using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            char ch;
            do
            {
                Console.Clear();
                // P1_PermutationsOfString p1 = new P1_PermutationsOfString();
                // p1.permutations();

                // P2_BinarySearch p2 = new P2_BinarySearch();
                // p2.binarySearch();

                // P3_InsertionSort p3 = new P3_InsertionSort();
                // p3.insertionSort();

                // P4_BubbleSort p4 = new P4_BubbleSort();
                // p4.bubbleSort();

                // P5_MergeSort p5 = new P5_MergeSort();
                // p5.mergeSort();

                // P6_Anagrams p6 = new P6_Anagrams();
                // p6.checkAnagrams();

                //P7_PrimeNumbers p7 = new P7_PrimeNumbers();
                //p7.primeNumbers();

                //P8_AnagramAndPalindromeNumber p8 = new P8_AnagramAndPalindromeNumber();
                //p8.anagramAndPalindrome();

                //P9_SearchingAndSortingUsingGenerics p9 = new P9_SearchingAndSortingUsingGenerics();
                //p9.SearchingAndSorting();

                //P10_FindYourNumber p10 = new P10_FindYourNumber();
                //p10.findNumber();


                //P11_TaskDoneByMaximumAmount p11 = new P11_TaskDoneByMaximumAmount();
                // p11.tasks();

                P12_CustomizedMessage p12 = new P12_CustomizedMessage();
                p12.printMessage();
                Console.Write("\nDo you want to continue? (y/n)      ");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y');



            Console.ReadKey();
        }
    }
}
