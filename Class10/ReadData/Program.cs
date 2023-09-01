using System;
using System.Globalization;


namespace ReadData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada de dados com String");
            Console.Write("Entre com o dia da semana: "); //recebe o valor do teclado na mesma linha da mensagem
            string diasemana = Console.ReadLine();
            Console.WriteLine("Dia de Hoje: " + diasemana);
            
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("Entrada de dados com Int");
            int a;
            Console.Write("Digite um numero inteiro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numero Digitado: {a}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Entrada de dados com Float");
            Console.Write("Digite um numero float: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Numero digitado: {b:0.00}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");

            double c;
            Console.WriteLine("Entrada de dados com Double");
            Console.Write("Digite um numero double: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero digitado: " + c.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Entrada de dados com Decimal");
            Console.Write("Digite um numero decimal: ");
            decimal d = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Numero digitado: {d:0.00}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Entrada de dados com char");
            Console.Write("Digite o seu genero sexual: ");
            char g = char.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou a opcao sexual " + g);

        }
    }
}