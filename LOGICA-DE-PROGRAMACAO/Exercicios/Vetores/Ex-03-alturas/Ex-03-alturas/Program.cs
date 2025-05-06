using System;
using System.Globalization;

namespace Course
{
    public class Alturas
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas? ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Dados da {i + 1}ª pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
            }
            int cont = 0;
            double somaAlturas = 0.0;
            for (int i = 0; i < N; i++)
            {
                somaAlturas += alturas[i];
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");
            double alturaMedia = somaAlturas / N;
            Console.WriteLine($"Altura media: {alturaMedia.ToString("F2", CI)}");
            double menorIdades = ((double)cont / N) * 100.0;
            Console.WriteLine($"Pessoas com menos de 16 anos: {menorIdades.ToString("F1", CI)}%");
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}