using System;
using System.Globalization;

namespace Course
{
    public class Lanchonete
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int produto, quantidade;
            double pagamento;

            Console.Write("Codigo do produto comprado: ");
            produto = int.Parse(Console.ReadLine());
            Console.Write("Quantida comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            switch (produto)
            {
                case 1:
                    pagamento = quantidade * 5.00;
                    Console.WriteLine("Valor a pgar: R$ " +pagamento.ToString("F2", CI));
                    break;
                case 2:
                    pagamento = quantidade * 3.50;
                    Console.WriteLine("Valor a pgar: R$ " + pagamento.ToString("F2", CI));
                    break;
                case 3:
                    pagamento = quantidade * 4.80;
                    Console.WriteLine("Valor a pgar: R$ " + pagamento.ToString("F2", CI));
                    break;
                case 4:
                    pagamento = quantidade * 8.90;
                    Console.WriteLine("Valor a pgar: R$ " + pagamento.ToString("F2", CI));
                    break;
                case 5:
                    pagamento = quantidade * 7.32;
                    Console.WriteLine("Valor a pgar: R$ " + pagamento.ToString("F2", CI));
                    break;
                default:
                    Console.WriteLine("Codigo invalido!");
                    break;
            }
        }
    }
}