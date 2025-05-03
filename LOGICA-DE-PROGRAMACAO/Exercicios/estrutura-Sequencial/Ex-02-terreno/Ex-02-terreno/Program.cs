using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            // declaracao das variaveis
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, metroQuadrado, area, preco;

            // entrada de dados
            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do metro quadrado: ");
            metroQuadrado = double.Parse(Console.ReadLine());

            // procesamento dos dados
            area = largura * comprimento;
            preco = metroQuadrado * area;

            // saida de dados
            Console.WriteLine("Area do terreno = " + area.ToString("F2", CI));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", CI));
        }
    }
}