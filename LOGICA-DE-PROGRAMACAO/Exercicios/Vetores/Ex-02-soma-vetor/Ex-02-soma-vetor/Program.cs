using System;
using System.Globalization;

namespace Course
{
    public class SomaVetor
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
            double soma = 0;
            Console.Write("VALORES =");
            for (int i = 0; i < N; i++)
            {
                Console.Write(" " + vet[i].ToString("F1", CI));
                soma += vet[i];
            }
            Console.WriteLine();
            Console.WriteLine($"SOMA = {soma.ToString("F2", CI)}");
            double media = soma / N;
            Console.WriteLine($"MEDIA = {media.ToString("F2", CI)}");
        }  
    }
}