using System;

namespace Course
{
    public class NegativosMatriz
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            Console.WriteLine("Digite os elementos da matriz:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int somaAcimaDiagonal = 0;
            for (int i = 0; i < N; i++) 
            { 
                for (int j = 1; j < N; j++) 
                {
                    if (j > i)
                    {
                        somaAcimaDiagonal += mat[i, j];
                    }
                }
            }
            Console.WriteLine($"SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = {somaAcimaDiagonal}");
        }
    }
}