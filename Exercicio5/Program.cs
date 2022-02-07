using System;
/**
 -Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
iguais deverá se somar os dois, caso contrário multiplique A por B.
-Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
variável C e mostrar seu conteúdo na tela.
 */
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida;
            do
            {
                Console.Write("Digite o valor de A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B: ");
                int b = int.Parse(Console.ReadLine());
                int c;

                if (a == b)
                {
                    c = a + b;
                    Console.WriteLine($"O valor de C = {c}");
                }
                if(a != b)
                {
                    c = a * b;
                    Console.WriteLine($"O valor de C = {c}");
                }

                Console.WriteLine("\n-Digite (s) para sair. Ou qualquer tecla para continuar.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
