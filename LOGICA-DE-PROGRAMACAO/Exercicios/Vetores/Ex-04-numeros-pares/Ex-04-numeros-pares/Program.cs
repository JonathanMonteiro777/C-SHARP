using System;

namespace Course
{
    public class NumerosPares
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("NUMEROS PARES:");
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    cont++;
                    Console.Write( numeros[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"QUANTIDADE DE PARES = {cont}");
        }
    }
}