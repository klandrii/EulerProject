using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EulerProject9
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Here we need  to find a poduct of abc, knowing that a^2+b^2=C^2 , a<b<c and a+b+c=1000
            int sum = 1000;
            for (int a = 1; a <sum/3; a++)
            {
                for (int b = a; b < sum/2; b++)
                {
                    int c = sum-(a+b);
                    if (a*a + b*b ==c*c)
                    {
                        int result = a * b * c;
                        Console.WriteLine(result);
                        Clipboard.SetText(Convert.ToString(result));
                    }
                }
            }
        }
    }
}
