using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var instance1 = new Euler1();
            var instance2 = new Euler9();
            var instance3 = new Euler10();
            Console.WriteLine("Problem #1 : {0}", instance1.Answer());
            Console.WriteLine("Problem #9 : {0}", instance2.Answer());
            Console.WriteLine("Problem #10 : {0}", instance3.Answer());
        }
    }

    internal class Euler1
    {
        private int result = 0;

        public string Answer()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    result += i;
                }
            }
            return Convert.ToString(result);
        }
    }

    internal class Euler9
    {
        private int sum = 1000;
        private string wrong = "wrong";

        public string Answer()
        {
            for (int a = 1; a < sum / 3; a++)
            {
                for (int b = a; b < sum / 2; b++)
                {
                    int c = sum - (a + b);
                    if (a * a + b * b == c * c)
                    {
                        int result = a * b * c;
                        return Convert.ToString(result);
                    }
                }
            }

            return wrong;
        }
    }

    internal class Euler10
    {
        //Find sum for all primes bellow two million
        int n = 1000000;
        bool[] sieve = new bool[2000000];
        List<double> primes = new List<double>();
        public string Answer()
        {
            for (int i = 2; i < sieve.Length; i++)
            {
                sieve[i] = true;
            }
            for (int i = 2; Math.Pow(i,2)< sieve.Length; i++)  // removing all multiples of 2 
            {
                for (int j = (int)Math.Pow(i,2); j < sieve.Length; j+=i)//all multiples of >2 are not primes
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