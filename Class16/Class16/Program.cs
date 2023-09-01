namespace Class16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibo = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int n in fibo)
            {
                Console.WriteLine(n);
            }

            string[] names = { "Romulo", "Obelix", "Bruce Wayne", "Clark Kent", "Han Solo" };
            foreach(string name in names)
            {
                Console.WriteLine("Name: " + name);
            }
        }
    }
}