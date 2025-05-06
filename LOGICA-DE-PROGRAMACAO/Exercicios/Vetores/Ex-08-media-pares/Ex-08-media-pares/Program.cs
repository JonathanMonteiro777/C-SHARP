using System;
using System.Globalization;

namespace Course
{
    public class MediaPares
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            // calculando a media dos pares
            double soma = 0;
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    soma += vet[i];
                    cont++;
                }
            }

            if (soma > 0)
            {
                double media = soma / cont;
                Console.WriteLine($"MEDIA DOS PARES = {media.ToString("F1", CI)}");
            }
            else
            {
                Console.WriteLine("NENHUM NUMERO PAR");
            }


        }
    }
}