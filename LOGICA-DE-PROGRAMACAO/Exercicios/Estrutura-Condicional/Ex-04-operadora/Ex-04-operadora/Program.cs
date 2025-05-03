using System;
using System.Globalization;

namespace Course
{
    public class Operadora
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int minutos, minutosExcedidos;
            double franquia, pagamento;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());


            if (minutos <= 100)
            {
                franquia = 50.00;
                Console.WriteLine("Valor a pagar: R$" + franquia.ToString("F2", CI));
            }
            else
            {
                minutosExcedidos = minutos - 100;
                pagamento = minutosExcedidos * 2.00;
                franquia = pagamento + 50.00;
                Console.WriteLine("Valor a pagar: R$" + franquia.ToString("F2", CI));
            }
        }
    }
}