using System;
using System.Globalization;

namespace Course
{
    public class DadosPessoas
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas? ");
            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            string[] generos = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Altura da {i + 1}a pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write($"Genero da {i + 1}a pessoa: ");
                generos[i] = Console.ReadLine().ToLower();
            }

            // Inicializa menorAltura e maiorAltura com o primeiro elemento
            double menorAltura = alturas[0];
            double maiorAltura = alturas[0];

            for (int i = 1; i < N; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }
            }
            Console.WriteLine($"Menor altura = {menorAltura.ToString("F2", CI)}");
            Console.WriteLine($"Maior altura = {maiorAltura.ToString("F2", CI)}");

            int contMulheres = 0;
            int contHomens = 0;
            double somaAlturasMulheres = 0;

            for (int i = 0; i < N; i++)
            {
                if (generos[i] == "f")
                {
                    somaAlturasMulheres += alturas[i];
                    contMulheres++;
                }
                else if (generos[i] == "m")
                {
                    contHomens++;
                }
            }

            double mediaMulheres = (contMulheres > 0) ? (somaAlturasMulheres / contMulheres) : 0;
            Console.WriteLine($"Media das alturas das mulheres = {mediaMulheres.ToString("F2", CI)}");
            Console.WriteLine($"Numero de homens = {contHomens}");
        }
    }
}