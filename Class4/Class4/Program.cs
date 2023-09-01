using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 12;
            int b = 2;
            int c = 12;

            Console.WriteLine(a < b);
            Console.WriteLine(b > c);
            Console.WriteLine(a == c);
            Console.WriteLine(b != c);
            Console.WriteLine(b <= c);
            Console.WriteLine(a >= b); // if(a >= b || a == c || c >= a) && || 


        }
    }
}
