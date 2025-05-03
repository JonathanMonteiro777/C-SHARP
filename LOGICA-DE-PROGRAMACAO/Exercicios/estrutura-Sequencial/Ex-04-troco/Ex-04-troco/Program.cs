using System;
using System.Globalization;

namespace Course
{
    public class Program 
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double produto, dinheiro, troco;
            int quantidade;

            Console.Write("Preco unitario do produto: ");
            produto = double.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine());

            troco = dinheiro - produto * quantidade;

            Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
        }
    }
}