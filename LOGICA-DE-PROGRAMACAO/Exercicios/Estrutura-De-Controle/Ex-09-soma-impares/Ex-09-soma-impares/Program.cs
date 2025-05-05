using System;

namespace Course
{
    public class SomaImpares
    {
        static void Main(string[] args)
        {
            int X, Y, menor, maior;
            int soma = 0;

            Console.WriteLine("Digite dois numeros:");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                menor = X;
                maior = Y;
            }
            else
            {
                menor = Y;
                maior = X;
            }
            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    soma+= i;
                }
            }
            Console.WriteLine($"SOMA DOS PARES = {soma}");
        }
    }
}