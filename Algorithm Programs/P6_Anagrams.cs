using System;

namespace DataStructure
{
    class P6_Anagrams
    {
        public void checkAnagrams()
        {
            Console.Write("Enter first string:   ");
            string str1 = Console.ReadLine();
            Console.Write("\nEnter second string:   ");
            string str2 = Console.ReadLine();

            char[] strArr1 = str1.ToLower().ToCharArray();
            char[] strArr2 = str2.ToLower().ToCharArray();

            sorting(strArr1);  
            sorting(strArr2);

            string s1 = new string(strArr1);
            string s2 = new string(strArr2);

            if (s1.Equals(s2))
            {
                Console.WriteLine("\nString {0} and {1} are anagram of each other.", str1, str2);
            }
            else
            {
                Console.WriteLine("\nString {0} and {1} are not anagrams.", str1, str2);
            }
        }

        public void sorting(char[] arr)
        {           
            for (int i = 0; i < arr.Length; i++)     
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        char temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;                       
                    }                  
                }
            }         
        }
    }
}
