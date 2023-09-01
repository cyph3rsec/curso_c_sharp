using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            bool repeat = false;

            while (repeat)
            {
                Console.WriteLine("While");
            }

            do
            {
                Console.WriteLine("Do While");
            }while (repeat);

            */

            int a = 0;

            do
            {
                Console.WriteLine("a = {0}", a);
                a++;

                if (a > 6)
                    break;

            } while (a < 10);

            Console.ReadKey();

        }
    }
}
