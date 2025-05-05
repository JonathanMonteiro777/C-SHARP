using System;

namespace Course
{
    public class DentroFora
    {
        static void Main(string[] args)
        {
            int N, x;
            int dentro = 0;
            int fora = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x < 10 || x > 20)
                {
                    fora++;
                }
                else
                {
                    dentro++;
                }
            }
            Console.WriteLine($"{dentro} DENTRO");
            Console.WriteLine($"{fora} FORA");
        }
    }
}