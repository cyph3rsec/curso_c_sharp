
using System.Globalization;

namespace Class14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Romulo";
            int age = 34;
            double sal = 25000.01788;

            Console.WriteLine("My name is " + name);
            Console.Write("My text\n");
            Console.WriteLine($"My salary is ${sal:0.00}");
            Console.WriteLine("My salary is " + sal.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}