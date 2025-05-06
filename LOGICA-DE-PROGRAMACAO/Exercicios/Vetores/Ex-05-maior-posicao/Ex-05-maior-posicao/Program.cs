using System;
using System.Globalization;

namespace Course
{
    public class MaiorPosicao
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();
            double maior = vet[0];
            int posicao = 0;
            for (int i = 1; i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"MAIOR VALOR = {maior.ToString("F1", CI)}");
            Console.WriteLine($"POSICAO DO MAIOR VALOR = {posicao}");
        }
    }
}