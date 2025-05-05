using System;
using System.Threading.Channels;

namespace Course
{
    public class ParesConsecutivos
    {
        static void Main(string[] args)
        {
            int x, soma;
            int numPar = 0;

            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {


                if (x % 2 == 0)
                {
                    numPar = x;
                }
                else
                {
                    numPar = x + 1;
                }

                soma = numPar * 5 + 20;
                Console.WriteLine($"SOMA = {soma}");

                Console.Write("Digite um numero inteiro: ");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}