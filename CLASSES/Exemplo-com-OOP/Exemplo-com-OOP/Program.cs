using Exemplo_com_OOP;
using System;
using System.Globalization;

namespace Course
{
    public class ExemploSemOOP
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double areaX = x.Area();


            double areaY = y.Area();

            Console.WriteLine($"Area de X = {areaX.ToString("F4", CI)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CI)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}