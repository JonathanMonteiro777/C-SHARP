using System;

namespace Course
{
    public class Fatorial
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Digite o valor de N (máximo 15): ");
            N = int.Parse(Console.ReadLine());

            if (N >= 0 && N <= 15)
            {
                int res = 1;
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        res *= i;
                    }
                }
                Console.WriteLine($"FATORIAL = {res}");
            }
            else
            {
                Console.WriteLine("Valor de N fora do intervalo permitido (0 a 15).");
            }
        }
    }
}