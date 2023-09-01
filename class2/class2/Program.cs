using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1234567890;
            long n2 = n1;
            Console.WriteLine(n2);

            double d1 = 335.547;
            int d2 = (int)d1;
            Console.WriteLine(d2);

            double f1 = 436.43577765;
            float f2 = (float)f1;
            Console.WriteLine(f2);
        }
    }
}
