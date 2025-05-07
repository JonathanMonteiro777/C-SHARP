using System;

namespace Course
{
    public class NegativosMatriz
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a quantidade de linhas da matriz? ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }
        }
    }
}