using System;
using System.Globalization;

namespace Course
{
    public class Dardo
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double dardo1, dardo2, dardo3, maiorDistancia;

            Console.WriteLine("Digite as tres distancias:");
            dardo1 = double.Parse(Console.ReadLine(), CI);
            dardo2 = double.Parse(Console.ReadLine(), CI);
            dardo3 = double.Parse(Console.ReadLine(), CI);

            if (dardo1 > dardo2 && dardo1 > dardo3)
            {
                maiorDistancia = dardo1;
                Console.WriteLine("MAIOR DISTANCIA = " + maiorDistancia.ToString("F2", CI));
            }
            else if (dardo2 > dardo3)
            {
                maiorDistancia = dardo2;
                Console.WriteLine("MAIOR DISTANCIA = " + maiorDistancia.ToString("F2", CI));
            }
            else
            {
                maiorDistancia = dardo3;
                Console.WriteLine("MAIOR DISTANCIA = " + maiorDistancia.ToString("F2", CI));
            }
        }
    }
}