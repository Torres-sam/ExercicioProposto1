using System;
using System.Globalization; 
namespace ExercicioProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int resultado = valor1 + valor2;

            Console.WriteLine($"A soma de {valor1} e {valor2} é igual a {resultado} !!!");
        }
    }
}