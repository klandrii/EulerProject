using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems
{
    internal class Euler10
    {
        //Find sum for all primes bellow two million
        private bool[] sieve = new bool[2000000];

        private List<double> primes = new List<double>();

        public string Answer()
        {
            for (int i = 2; i < sieve.Length; i++)
            {
                sieve[i] = true;
            }
            for (int i = 2; Math.Pow(i, 2) < sieve.Length; i++)  // removing all multiples of 2
            {
                for (int j = (int)Math.Pow(i, 2); j < sieve.Length; j += i)//all multiples of >2 are not primes
                {
                    sieve[j] = false;
                }
            }
            for (int i = 2; i < sieve.Length; i++)
            {
                if (sieve[i])
                {
                    primes.Add(i);
                }
            }
            string result = primes.Sum().ToString();
            return result;
        }
    }
}