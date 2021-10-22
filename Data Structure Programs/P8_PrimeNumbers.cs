using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class P8_PrimeNumbers
	{

		int countPrimes(int l, int r)
		{
			int count = 0;
			for (int i = l; i <= r; i++)
			{
                if (isPrime(i))
                {
					count++;
				}				
			}
			return count;
		}
		 bool isPrime(int n)
		 {
			int c = 0;
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
					c++;
			}

			return (c == 2);
		 }

		public void primeNumbers()
		{
			int[] counts = new int[10];
			int right = 0;
			int s = 0;
			for (int t = 1; t <= 1000; t = t + 100)
			{
				right = right + 100;
				int res = countPrimes(t, right);
				
				counts[s] = res;
				s++;
			}
			int m = 10;
			int n = 25;
			string[,] primes = new string[m, n];   // 2D array for prime numbers

			string[] num = new string[m * n];     // 1D array for prime numbers

			int i = 0, j;
			int k = 1;
			while (i < m * n)
			{
				if (isPrime(k) == true)
				{
					num[i] = k.ToString();
					i++;
				}
				k++;
			}

			int x = 0;    // index for num array
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < counts[i]; j++)
				{
					primes[i, j] = num[x];
					x++;
				}
			}

			for (i = 0; i < m; i++)
			{
				for (j = 0; j < n; j++)
				{
					if (primes[i, j] != null)
					{
						Console.Write(primes[i, j] + " ");
					}

				}
				Console.WriteLine();
			}
		}
	}
}
