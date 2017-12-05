using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var instance1 = new EulerProblems.Euler1();
            var instance2 = new EulerProblems.Euler9();
            var instance3 = new EulerProblems.Euler10();
            var instance4 = new InterwiewQuestions.MostFrequentArray();
            Console.WriteLine("Problem #1 : {0}", instance1.Answer());
            Console.WriteLine("Problem #9 : {0}", instance2.Answer());
            Console.WriteLine("Problem #10 : {0}", instance3.Answer());
            Console.WriteLine("Problem #1 : {0}", instance4.Answer());
        }
    }

    namespace EulerProblems
    {
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

    namespace InterwiewQuestions
    {
        internal class MostFrequentArray //Return most frequent number in array
        {
            private int[] myArray = { 1, 2, 2, 3, 4, 4, 2, 1 };// array sample
            public Dictionary<int, int> countDictionary = new Dictionary<int, int>();//Key is Item Value is quantity of that item

            public string Answer()
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (countDictionary.ContainsKey(myArray[i]))//checking if dictionary already contains element from myArray
                    {
                        countDictionary[i]++;//increasing value by 1
                    }
                    else
                    {
                        countDictionary.Add(i, 1);// adding value/key pair to dictionary 
                    }
                }

                return Convert.ToString(countDictionary);
            }
        }
    }
}