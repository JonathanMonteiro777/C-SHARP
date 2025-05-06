using System;

namespace Course
{
    public class MaisVelho
    {
        static void Main(string[] args)
        {

            Console.Write("Quantas pessoas voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            // Verificando e exibindo a pessoa mais velha
            int maisVelho = 0;
            for (int i = 1; i < N; i++)
            {
                if (idades[i] > idades[maisVelho])
                {
                    maisVelho = i;
                }
            }
            Console.WriteLine($"PESSOA MAIS VELHA: {nomes[maisVelho]}");
        }
    }
}