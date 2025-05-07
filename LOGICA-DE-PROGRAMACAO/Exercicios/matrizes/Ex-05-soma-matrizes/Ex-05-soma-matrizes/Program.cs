using System;

namespace Course
{
    public class NegativosMatriz
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas linhas vai ter cada matriz? ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            int N = int.Parse(Console.ReadLine());


            int[,] matA = new int[M, N];
            int[,] matB = new int[M, N];
            int[,] matC = new int[M, N];

            Console.WriteLine("Digite os valores da matriz A: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matB[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("MATRIZ SOMA:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matC[i,j] = matA[i,j] + matB[i,j];
                    Console.Write(matC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}