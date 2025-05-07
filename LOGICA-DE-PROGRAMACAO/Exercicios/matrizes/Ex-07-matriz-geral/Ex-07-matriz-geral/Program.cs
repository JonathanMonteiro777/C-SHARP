using System;
using System.Globalization;

namespace Course
{
    public class MatrizGeral
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            // 1º calcular e imprimir a soma de todos os elementos positivos da matriz.
            double somaPositivos = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        somaPositivos += mat[i, j];
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine($"SOMA DOS POSITIVOS: {somaPositivos.ToString("F1", CI)}");
            Console.WriteLine();

            // 2º fazer a leitura do índice de uma linha da matriz
            // e imprimir todos os elementos desta linha
            Console.Write("Escolha uma linha: ");
            int linhaEscolhida = int.Parse(Console.ReadLine());


            if (linhaEscolhida >= 0 && linhaEscolhida < N)
            {
                Console.Write("LINHA ESCOLHIDA: ");
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[linhaEscolhida, j].ToString("F1", CI) + " ");
                }
            }
            else
            {
                Console.WriteLine("indice de linha ivalido.");
            }
            Console.WriteLine();

            // 3º fazer a leitura do índice de uma coluna da matriz
            // e imprimir todos os elementos desta coluna. 
            Console.Write("Escolha uma coluna: ");
            int colunaEscolhida = int.Parse(Console.ReadLine());


            if (colunaEscolhida >= 0 && colunaEscolhida < N)
            {
                Console.Write("COLUNA ESCOLHIDA: ");
                for (int i = 0; i < N; i++)
                {
                    Console.Write(mat[i, colunaEscolhida].ToString("F1", CI) + " ");
                }
            }
            else
            {
                Console.WriteLine("indice de coluna invalido.");
            }
            Console.WriteLine();

            //  imprimir os elementos da diagonal principal da matriz.
            Console.Write("\nDIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i].ToString("F1", CI) + " ");
            }
            Console.WriteLine();

            // alterar a matriz elevando ao quadrado todos os números negativos da mesma
            // e imprimir a matriz alterada.
            Console.WriteLine("\nMATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        mat[i, j] = Math.Pow(mat[i, j], 2);
                    }
                    Console.Write(mat[i, j].ToString("F1", CI) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}