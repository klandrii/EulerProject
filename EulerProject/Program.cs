using System;

namespace EulerProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var instance1= new Euler1();
            var instance2 = new Euler9();
            Console.WriteLine(instance1.Answer());
            Console.WriteLine(instance2.Answer());
        }
    }
    class Euler1
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
    class Euler9
    {
        private int sum = 1000;
        private string wrong = "wrong";

        public string Answer()
        {
            for (int a = 1; a < sum / 3; a++)
            {
                for (int b = a; b < sum/2; b++)
                {
                    int c = sum - (a + b);
                    if (a*a + b*b == c*c)
                    {
                        int result = a * b * c;
                        return Convert.ToString(result);
                    }
                }
                
            }

            return wrong;
        }
    }
}
