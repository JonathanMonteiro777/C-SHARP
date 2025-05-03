using System;
using System.Globalization;

namespace Course
{
    public class TrocoVerificado
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int quantidade;
            double produto, pagamento, compra, troco;

            Console.Write("Preco unitario do produto: ");
            produto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            pagamento = double.Parse(Console.ReadLine(), CI);

            compra = (double)produto * quantidade;
            troco = pagamento - compra;
            if (pagamento > compra)
            {
                Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
            }
            else
            {
                double valorFaltante = compra - pagamento;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + valorFaltante.ToString("F2", CI) + " REAIS");
            }
        }
    }
}
