using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    internal class Program
    {
        static void Main(string[] args)
        { //AND = &&    |  OR = ||     | NOT = !
            int a = 14;
            int b = 14;

            Console.WriteLine(a == b && b == 14);
            Console.WriteLine(a == 14 || b == 15);
            Console.WriteLine(!(a == b));

        }
    }
}
