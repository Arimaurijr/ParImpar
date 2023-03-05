using System.Globalization;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double numero = 0.0;

        Console.WriteLine("Digite um número");
        numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (numero % 2 == 0.0)
        {
            Console.WriteLine("O número digitado é PAR");
        }
        else
        {
            Console.WriteLine("O número digitado é ÍMPAR");
        }
    }
}