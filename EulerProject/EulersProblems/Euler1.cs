using System;

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
}