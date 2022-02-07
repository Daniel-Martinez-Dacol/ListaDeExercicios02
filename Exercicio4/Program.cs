using System;
/**
- Faça um algoritmo para receber um número qualquer e informar na tela se
é par ou ímpar. 
 */
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida;
            do
            {
                Console.Write("Digite o numero: ");
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"O numero {num} é par.");
                }
                else
                {
                    Console.WriteLine($"O numero {num} é ímpar.");
                }

                Console.WriteLine("\n-Digite (s) para sair. Ou qualquer tecla para continuar.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
