using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace InterwiewQuestions
{
    internal class MostFrequentArray //Return most frequent number in array
    {
        private readonly int[] myArray = { 1, 2, 2, 3, 4, 4, 2, 1 };// array sample
        public Dictionary<int, int> CountDictionary = new Dictionary<int, int>();//Key is Item Value is quantity of that item

        public string Answer()
        {
            foreach (int item in myArray)
            {
                if (CountDictionary.ContainsKey(myArray[item]))//checking if dictionary already contains element from myArray
                {
                    CountDictionary[item]++; //increasing value by 1?? 
                }
                else
                {
                    CountDictionary.Add(item, 1);// adding value/key pair to dictionary 
                }
            }
            var max = from x in CountDictionary where x.Value == CountDictionary.Max(v => v.Value) select x.Key;//not working as intended yet
            string result = max.GetEnumerator().ToString();
            return result;
        }
    }
}