using System;

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

}