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

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("MAIOR ELEMNTO DE CADA LINHA:");
            for (int i = 0; i < N; i++)
            {
                int maior = mat[i, 0];
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}