using System;

namespace Course
{
    public class DiagonalNegativos
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i,j]+" ");
                    }
                }
            }
        }
    }
}