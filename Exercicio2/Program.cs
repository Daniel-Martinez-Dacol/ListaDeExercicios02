using System;
/**
Escreva um algoritmo que leia três valores inteiros e diferentes e
mostre-os em ordem decrescente.
 */
namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida;
            do { 
            Console.Write("-Digite o primeiro valor: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("-Digite o segundo valor: ");
            int val2 = int.Parse(Console.ReadLine());
            Console.Write("-Digite o terceiro valor: ");
            int val3 = int.Parse(Console.ReadLine());
            //valor 1 > valor 2 > valor 3
            if (val1 > val2 && val2 >val3)
            {
                Console.WriteLine($"EM ORDEM DECRECENTE:\n-{val1}\n{val2}\n-{val3}");
            }
            //valor 1 > valor 3 > valor 2
            if (val1 > val3 && val3 > val2)
            {
                Console.WriteLine($"EM ORDEM DECRECENTE:\n-{val1}\n-{val3}\n- {val2}");
            }
            // valor 2 > valor 1 > valor 3
            if (val2 > val1 && val1 > val3)
            {
                Console.WriteLine($"EM ORDEM DECRECENTE:\n-{val2}\n-{val1}\n-{val3}");
            }
            //valor 2 > valor 3 > valor 1
            if (val2 > val3 && val3 > val1)
            {
                Console.WriteLine($"EM ORDEM DECRECENTE:\n-{val2}\n-{val1}\n-{val3}");
            }
            // valor 3 > valor 1 > valor 2
            if (val3 > val1 && val1 > val2)
            {
                Console.WriteLine($"EM ORDEM DECRECENTE:\n-{val3}\n-{val1}\n-{val2}");
            }
            // valor 3 > valor 2 > valor 1
            if (val3 > val2 && val2 > val1)
            {
                Console.WriteLine($"EM ORDEM DECRECENTE:\n-{val3}\n-{val2}\n-{val1}");
            }
            
            Console.WriteLine("\n-Digite (s) para sair.");
            saida = Console.ReadLine();
        } while (saida != "s");
        }
    }
}
