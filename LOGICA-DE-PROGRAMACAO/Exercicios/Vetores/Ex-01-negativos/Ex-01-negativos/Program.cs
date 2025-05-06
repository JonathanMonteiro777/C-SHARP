using System;

namespace Course
{
    public class Negativos
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}