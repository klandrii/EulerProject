using System;
using System.Windows.Forms;

namespace EulerProject
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Bruteforce solution, ill try checking all ints from 1 to 1000 for being multiples of 3 and 5
            int result = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    result += i;// sum of all multiples
                }
            }
            Console.WriteLine(result);
            Clipboard.SetText(Convert.ToString(result));// now ill copy our result to clipboard, for for convenience sake
        }
    }
}
