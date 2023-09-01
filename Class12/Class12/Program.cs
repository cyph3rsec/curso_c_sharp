namespace Class12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double weight;
            decimal salary;
            char gender;

            Console.WriteLine("Enter the information");

            Console.Write("\nName: ");
            name = Console.ReadLine();

            Console.Write("\nAge: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nWeight: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSalary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nGender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.ReadKey();
        }
    }
}