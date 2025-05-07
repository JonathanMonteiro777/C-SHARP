using System;
using System.Globalization;

namespace Course
{
    public class Comerciante
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Serao digitados dados de quantos produtos? ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] valorCompra = new double[N];
            double[] valorVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Produto {i + 1}:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                valorCompra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                valorVenda[i] = double.Parse(Console.ReadLine(), CI);
            }

            // calcular a porcentagem de lucro dos produtos
            int lucroBaixo = 0;
            int lucroMedio = 0;
            int lucroAcima = 0;
            double lucroMercadoria;
            double porcentagemLucro;

            for (int i = 0; i < N; i++)
            {
                lucroMercadoria = valorVenda[i] - valorCompra[i];
                porcentagemLucro = (lucroMercadoria / valorCompra[i]) * 100.0;

                if (porcentagemLucro < 10.0)
                {
                    lucroBaixo++;
                }
                else if (porcentagemLucro >= 10.0 && porcentagemLucro <= 20.0)
                {
                    lucroMedio++;
                }
                else
                {
                    lucroAcima++;
                }
            }

            // calcular o valor total dos produtos
            double totCompra = 0.0;
            double totVenda = 0.0;

            for (int i = 0; i < N; i++)
            {

                totCompra += valorCompra[i];
                totVenda += valorVenda[i];
            }
            double totLucro = totVenda - totCompra;

            Console.WriteLine("\nRELATORIO:");
            Console.WriteLine($"Lucro abaixo de 10%: {lucroBaixo}");
            Console.WriteLine($"Lucro etre 10% e 20%: {lucroMedio}");
            Console.WriteLine($"Lucro acima de 20%: {lucroAcima}");
            Console.WriteLine($"Valor total de compra: {totCompra.ToString("F2", CI)}");
            Console.WriteLine($"Valor total de venda: {totVenda.ToString("F2", CI)}");
            Console.WriteLine($"Lucro total: {totLucro.ToString("F2", CI)}");
        }
    }
}