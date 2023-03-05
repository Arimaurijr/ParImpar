using System.Globalization;
using System;

internal class Program
{

    private static void Main(string[] args)
    {
        double numero = 0.0;
        bool verificacao = false;

        void Entrada()
        {
            Console.WriteLine("Digite um número");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        bool ParImpar()
        {
            if (numero % 2 == 0)
            {
                verificacao = true;
            }

            return verificacao;
        }

        void Saida()
        {
            if (ParImpar())
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }

        Entrada();
        ParImpar();
        Saida();

    }
}