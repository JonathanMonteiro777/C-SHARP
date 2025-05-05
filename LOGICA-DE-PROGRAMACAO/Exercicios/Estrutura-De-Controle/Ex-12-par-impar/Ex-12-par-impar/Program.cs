using System;

namespace Course
{
    public class ParImpar
    {
        static void Main(string[] args)
        {
            int N, X;
            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um nmero: ");
                X = int.Parse(Console.ReadLine());
                
                if (X % 2 != 0 && X > 0)
                {
                    Console.WriteLine("IMPAR POSITIVO");
                }
                else if (X % 2 != 0 && X < 0)
                {
                    Console.WriteLine("IMPAR NEGATIVO");
                }
                else if (X % 2 == 0 && X > 0)
                {
                    Console.WriteLine("PAR POSITIVO");
                }
                else if (X % 2 == 0 && X < 0)
                {
                    Console.WriteLine("PAR NEGATIVO");
                }
                else
                {
                    Console.WriteLine("NULO");
                }
            }
        }
    }
}