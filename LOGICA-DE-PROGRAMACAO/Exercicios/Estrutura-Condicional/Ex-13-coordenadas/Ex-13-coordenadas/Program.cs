using System;
using System.Globalization;

namespace Course
{
    public class Coordenadas
    {
        static void Main(string[] args)
        { 
            CultureInfo CI = CultureInfo.InvariantCulture;

            double X, Y;

            Console.Write("Valor de X: ");
            X = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            Y = double.Parse(Console.ReadLine(), CI);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X > 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X == 0 && Y > 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}