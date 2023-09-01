using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int year, age;
            double weight, height, salary;
            char gender;
            string name, address;

            year = 1988;
            age = 34;
            weight = 114.8967;
            height = 1.881;
            salary = 32000.98899;
            gender = 'M';
            name = "Romulo";
            address = "Sao Paulo, SP";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Birth year: " + year);
            Console.WriteLine("Weight: " + weight.ToString("F2", CI));
            Console.WriteLine("Height: " + height.ToString("F2", CI));
            Console.WriteLine("Salary: " + salary.ToString("F2", CI));
            Console.WriteLine("Address: " + address);

        }
    }
}
