using System;
/**
- O IMC – Índice de Massa Corporal é um critério da Organização Mundial
de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
adulta
- A fórmula é IMC = peso / (altura) ²
- Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
sua condição de acordo com a tabela abaixo:

------|IMC em adultos Condição:
------|Abaixo de 18,5 : Abaixo do peso
------|Entre 18,5 e 25 : Peso normal
------|Entre 25 e 30 : Acima do peso
------|Acima de 30 : obeso
 
 */
namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida;
            do
            {
                Console.Write("Digite seu Peso: ");
                double peso = double.Parse(Console.ReadLine());
                Console.Write("Digite sua Altura: ");
                double altura = double.Parse(Console.ReadLine());

                //Calculo do IMC:
                double imc = peso / (altura * altura);
                Console.WriteLine(imc);

                if (imc < 18.5)
                {
                    Console.WriteLine("\n-SUA CONDIÇÃO È : Abaixo do Peso");
                }
                if (18.5 < imc && imc < 25)
                {
                    Console.WriteLine("\n-SUA CONDIÇÃO È : Peso Normal");
                }
                if (25 < imc && imc < 30)
                {
                    Console.WriteLine("\n-SUA CONDIÇÃO È : Acima do Peso");
                }
                if (imc > 30)
                {
                    Console.WriteLine("\n-SUA CONDIÇÃO È : Obeso");
                }

                Console.WriteLine("\n-Digite (s) para sair. Ou qualquer tecla para continuar.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
