using System;

namespace EulerProblems
{
    //-----------------------------------------------------------------------------
    //A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,
    //a2 + b2 = c2
    //For example, 32 + 42 = 9 + 16 = 25 = 52.
    //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    //Find the product abc.
    //-----------------------------------------------------------------------------
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
}