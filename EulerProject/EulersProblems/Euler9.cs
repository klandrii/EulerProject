using System;

namespace EulerProblems
{
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