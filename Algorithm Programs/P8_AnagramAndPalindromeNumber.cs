using System;
using System.Collections.Generic;

namespace DataStructure
{
    class P8_AnagramAndPalindromeNumber
    {
        List<int> primes = new List<int>();
        List<int> palindromes = new List<int>();
        List<string> numbers = new List<string>();
        public void anagramAndPalindrome()
        {
                       
            int n = 1000;
            bool flag;
            for (int i = 0; i <= n; i++)
            {
                if (i == 1 || i == 0)
                {
                    continue;
                }

                flag = true;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    primes.Add(i);
                    checkPalindrome(i);
                }
            }

            
            Console.WriteLine("Prime numbers from 0 to 1000 are:  ");
            foreach (var x in primes)
            {
                Console.WriteLine(x);              
            }

            Console.WriteLine("\nPalindromes and Prime number between 0 to 1000 are:  ");
            foreach (var p in palindromes)
            {
                Console.WriteLine(p);

            }

            Console.WriteLine("\nAnagram of Prime number between 0 to 1000 are:  ");
            sortedDigitsPrimes(primes);
            foreach (var p in primes )
            {
                checkAnagrams(p);
            }
          
        }
        void checkPalindrome(int num)
        {     
            int reverese = reverseNumber(num);
            if (reverese == num)
            {
                palindromes.Add(reverese);
            }                   
        }

        void checkAnagrams(int num)
        {
            List<string> anagrams = new List<string>();
            string N = num.ToString();

            char[] arr = N.ToCharArray();

            Array.Sort(arr);

            string number = new string(arr);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (number.Equals(numbers[i]))
                {   
                  
                    anagrams.Add(primes[i].ToString());
                }
            }

            if (anagrams.Count > 1)
            {
                Console.Write("\nAnagram of {0} :   ",N);
                foreach (var a in anagrams)
                {
                    Console.Write(a + "   ");
                }
            }
        }

        void sortedDigitsPrimes(List<int> primes)
        {
            foreach(var p in primes)
            {
                string N = p.ToString();

                char[] arr = N.ToCharArray();

                Array.Sort(arr);

                string number = new string(arr);

                numbers.Add(number);
            }
        }

        int reverseNumber(int num)
        {
            int reverese = 0;
            while (num > 0)
            {
                reverese = reverese * 10 + num % 10;
                num = num / 10;
            }
            return reverese;
        }        
    }
}
