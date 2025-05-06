using System;
using System.Globalization;

namespace Course
{
    public class AbaixoDaMedia
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();
            // calculando a media
            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }
            double media = soma / N;
            Console.WriteLine($"MEDIA DO VETOR = {media.ToString("F3", CI)}");

            // exibindo elementos abaixo da media
            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");
            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}