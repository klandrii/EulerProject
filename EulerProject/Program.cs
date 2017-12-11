using System;

namespace EulerProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Logger.InitLogger();// Logger Initialization 
            Logger.Log.Info("Staring log");
            var instance1 = new EulerProblems.Euler1();
            var instance2 = new EulerProblems.Euler9();
            var instance3 = new EulerProblems.Euler10();
            var instance4 = new InterwiewQuestions.MostFrequentArray();
            var instance5 = new EulerProblems.Euler11();
            var instance6 =new InterwiewQuestions.CommonElements();
            Console.WriteLine("Euler problem #1 : {0}", instance1.Answer());
            Console.WriteLine("Euler problem #9 : {0}", instance2.Answer());
            Console.WriteLine("Euler problem #10 : {0}", instance3.Answer());
            Console.WriteLine("Interview problem #1 : {0}", instance4.Answer());
            Console.WriteLine("Euler problem #11: {0}",instance5.Answer());
            Console.WriteLine("Interview problem #2 : {0}", instance6.Answer());
            //Console.WriteLine("Interview problem #2 : {0}", instance6.AnswerPure());
            Console.ReadLine();
        }
    }

}