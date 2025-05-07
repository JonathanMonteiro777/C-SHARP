using System;
using System.Globalization;

namespace Course
{
    public class SomaLinhas
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            int N = int.Parse(Console.ReadLine());

            double[,] Mat = new double[M,N];

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"Digite os elementos da {i}a. linha:");
                for (int j = 0; j < N; j++)
                {
                    Mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            double[] vet = new double[M];
            Console.WriteLine("\nVETOR GERADO:");
            for (int i = 0; i < M; i++)
            {
                double soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma += Mat[i, j];
                }
                vet[i] = soma;
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        }
    }
}