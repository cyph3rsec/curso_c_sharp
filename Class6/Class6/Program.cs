using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "romulo";
            string pass = "@123";

            if (user == "romulo" && pass == "@1234")
            {
                Console.WriteLine("Welcome to the panel");
            }
            else if (user == "romulo" || pass == "@12345")
            {
                Console.WriteLine("Welcome, the username is correct!");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }
    }
}
