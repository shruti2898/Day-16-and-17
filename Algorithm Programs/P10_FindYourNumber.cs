using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class P10_FindYourNumber
    {
        public int N, number;
        public void findNumber()
        {
            Console.Write("Enter a number: ");
            N = Convert.ToInt32(Console.ReadLine());
             
            int guesses = powerOfTwo(N);       // number of guesses is n where 2^n = N
            Console.WriteLine("\nYou have {0} guesses",guesses);

            Random random = new Random();
            number = random.Next(0, N);
            
            bool flag = false;

            for(int i=0; i< guesses; i++)
            {  
                
               

            }

            if (!flag)
            {
                Console.WriteLine("\nYou are out of guesse");
            }

        }

        void BinarySearch(int right, int left)
        {
            Console.WriteLine("\nGuess the number: ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            if(right>= left)
            {
                int mid = left + (right - left) / 2;
                if (number == mid)
                {
                    Console.WriteLine("\nYou guessed it right! Your guessed number is {0}", number);
                    //flag = true;
                   
                }
                else if (guessedNumber > number)
                {
                    Console.WriteLine("\nYour guessed number {0} is higher than the actual number. Try again", guessedNumber);
                }
                else
                {
                    Console.WriteLine("\nYour guessed number {0} is lower than the actual number. Try again", guessedNumber);
                }
            }

            
        }


        int powerOfTwo(int num)
        {
           
            int x = num & (num - 1);
            int power=0;
            int nearest=0;
            if(x == 0)
            {   int i = 0;
                while (i >= 0)
                {
                    double temp = Math.Pow(2, i);
                    if(num == temp)
                    {
                        power = i;
                        break;
                    }
                    i++;
                }
            }
            else
            {   int i = 0;
                while (i >= 0)
                {
                    int n = num + i;
                    int temp = n & (n - 1);
                    if (temp == 0)
                    {
                        nearest = n;
                        break;
                    }
                    i++;
                }
              power =  powerOfTwo(nearest);
            }

            return power;
        }
    }
}
