using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //+ - * / % 

            int a = 17;
            int b = 3;
            int c = 8;
            int d = 2;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);


            Console.WriteLine((a + d - c) * d / 2);

        }
    }
}
