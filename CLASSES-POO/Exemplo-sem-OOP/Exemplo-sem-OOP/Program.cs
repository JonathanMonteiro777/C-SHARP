using System;
using System.Globalization;

namespace Course
{
    public class ExemploSemOOP
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine(), CI);
            xB = double.Parse(Console.ReadLine(), CI);
            xC = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CI);
            yB = double.Parse(Console.ReadLine(), CI);
            yC = double.Parse(Console.ReadLine(), CI);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) *(p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) *(p - yB) * (p - yC));

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