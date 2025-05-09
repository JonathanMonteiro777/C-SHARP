using Ex_01_Fixacao;
using System;
using System.Globalization;

namespace Course
{
    public class ExFixacao
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CI);

            double result = ConversorDeMoedas.DolarParaReal(quantia, cotacao);

            Console.WriteLine();
            Console.WriteLine($"Valor aser pago em reais: {result.ToString("F2", CI)}");
        }
    }
}