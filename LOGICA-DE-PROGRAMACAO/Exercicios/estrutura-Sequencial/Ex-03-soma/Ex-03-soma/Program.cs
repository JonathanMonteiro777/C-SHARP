using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            // declaracao das variaveis
            int X, y, soma;
            
            // entrada de dados
            Console.Write("Digite o valor de X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            // logica para somar 
            soma = X + y;

            // saida de dados
            Console.WriteLine("SOMA = " + soma);
        }
    }
}