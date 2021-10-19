using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class P7_PrimeNumbers
    {
        public void primeNumbers()
        {
            Console.WriteLine("Prime numbers from 0 to 1000 are:  ");
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
                    Console.WriteLine(i + " ");
                }                    
            }            
        }
    }
}
