using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Enter a number to be calculated: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for(a = 1; a <=10; a++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", b, a, b * a);
            }

        }
    }
}
