using EulerProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterwiewQuestions
{
    //---------------------------------------------------------------------
    //Compare two  descending arrays of unknown size and find all common elements
    //---------------------------------------------------------------------
    class CommonElements
    {
        private int[] a = new int[] {1, 3, 4, 6, 7, 9};//sample arrays
        private int[] b = new int[] {1, 2, 4, 5, 9, 10};
        List<int> result = new List<int>();

        public string Answer()// First way to solve this problem using Enumerable.Intersect method
        {
            var intersection = a.Intersect(b);
            Logger.Log.Info("I'm using Enumerable.Intersect");
            return String.Join(",", intersection);
        }

        public string AnswerPure() // Let's just pretend that intersect method does not exist
        {
            for (int i = 0; i < a.Length; i++)// Ok it's time for some bruteforce
            {
                foreach (int item in b)
                {
                    if (a[i]==item)
                    {
                        result.Add(item);
                    }
                }
            }
            Logger.Log.Info("I'm using custom made method");
            return String.Join(",", result);
        }
    }
}
