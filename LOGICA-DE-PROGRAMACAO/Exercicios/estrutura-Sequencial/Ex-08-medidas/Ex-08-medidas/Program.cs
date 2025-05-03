using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double A, B, C, quadrado, triangulo, retangulo;

            Console.Write("Digite a medida A: ");
            A = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            B = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            C = double.Parse(Console.ReadLine(), CI);

            quadrado = Math.Pow(A, 2.0);
            triangulo = (A * B) / 2.0;
            retangulo = ((A + B) * C) / 2.0;

            Console.WriteLine("AREA DO QUADRADO = " + quadrado.ToString("F4", CI));
            Console.WriteLine("AREA DO TRIANGULO = " + triangulo.ToString("F4", CI));
            Console.WriteLine("AREA DO RETANGULO = " + retangulo.ToString("F4", CI));
        }
    }
}