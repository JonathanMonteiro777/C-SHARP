using System;
using System.Globalization;

namespace ValidacaoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double nota1, nota2;
            bool notaValida;

            // Ler e validar a primeira nota
            notaValida = false;
            do
            {
                Console.Write("Digite a primeira nota: ");
                nota1 = double.Parse(Console.ReadLine(), CI);
                if (nota1 >= 0 && nota1 <= 10)
                {
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido! Tente novamente:");
                }
            } while (!notaValida);

            // Ler e validar a segunda nota
            notaValida = false;
            do
            {
                Console.Write("Digite a segunda nota: ");
                nota2 = double.Parse(Console.ReadLine(), CI);
                if (nota2 >= 0 && nota2 <= 10)
                {
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido! Tente novamente:");
                }
            } while (!notaValida);

            // Calcular a média
            double media = (nota1 + nota2) / 2.0;

            // Imprimir a média
            Console.WriteLine($"MEDIA = {media.ToString("F2", CI)}"); // Formatação para duas casas decimais como nos exemplos
        }
    }
}