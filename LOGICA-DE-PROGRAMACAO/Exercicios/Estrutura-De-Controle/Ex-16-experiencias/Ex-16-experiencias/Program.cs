using System;
using System.Globalization;

namespace Course
{
    public class Experiencias
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string tipo;
            int N, quantidade;

            Console.Write("Quantos casos de teste serao digitados? ");
            N = int.Parse(Console.ReadLine());

            int totCoabais = 0;
            int totCoelhos = 0;
            int totRatos = 0;
            int totSapos = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                quantidade = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                tipo = Console.ReadLine().ToLower();

                if (tipo == "c")
                {
                    totCoelhos += quantidade; 
                }
                else if (tipo == "r")
                {
                    totRatos += quantidade; 
                }
                else if (tipo == "s")
                {
                    totSapos += quantidade; 
                }
                totCoabais += quantidade;
            }
            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine($"Total: {totCoabais} cobaias");
            Console.WriteLine($"Total de coelhos: {totCoelhos}");
            Console.WriteLine($"Total de ratos: {totRatos}");
            Console.WriteLine($"Total de sapos: {totSapos}");

            double percentualCoelhos = (double)totCoelhos / totCoabais * 100.0;
            double percentualRatos = (double)totRatos / totCoabais * 100.0;
            double percentualSapos = (double)totSapos / totCoabais * 100.0;

            Console.WriteLine($"Percentual de coelhos: {percentualCoelhos.ToString("F2", CI)}");
            Console.WriteLine($"Percentual de ratos: {percentualRatos.ToString("F2", CI)}");
            Console.WriteLine($"Percentual de sapos: {percentualSapos.ToString("F2", CI)}");
        }
    }
}