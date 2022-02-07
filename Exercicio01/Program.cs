using System;
/**
 Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
soma de A + B é menor que C.
 */
namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida = "";
            do
            {
                Console.Write("Digite o valor A :");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor B :");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor C :");
                float c = float.Parse(Console.ReadLine());

                if (a + b < c)
                {
                    Console.WriteLine($"A soma de A ({a}) + B ({b})é menor que C ({c})");
                }
                else
                {
                    Console.WriteLine($"A soma de A ({a}) + B ({b}) não é menor que C ({c})");
                }


                Console.WriteLine("\n-Digite (s) para sair.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
