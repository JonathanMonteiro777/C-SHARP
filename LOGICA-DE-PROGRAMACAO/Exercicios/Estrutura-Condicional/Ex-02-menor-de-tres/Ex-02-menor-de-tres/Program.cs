using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int A, B, C, menor;

            Console.Write("Primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            if (A < B && A < C)
            {
                menor = A;
            } else if (B < C)
            {
                menor = B;
            } else
            {
                menor = C;
            }

            Console.WriteLine("MENOR = " + menor);
        }
    }
}