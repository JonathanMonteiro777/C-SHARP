using System;
using System.Globalization;

namespace Course
{
    public class Notas
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double nota1, nota2, notaFinal;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digie a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            notaFinal = nota1 + nota2;

            if (notaFinal < 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CI));
                Console.WriteLine("REPROVADO");
            } else
            {
                Console.WriteLine("NOAT FINAL = " + notaFinal.ToString("F1", CI));
                Console.WriteLine("APROVADO");
            }
        }
    }
}