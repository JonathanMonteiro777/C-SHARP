using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double r, area;
            const double PI = 3.14159; 

            Console.Write("Digite o valor do raio do circulo: ");
            r = double.Parse(Console.ReadLine(), CI);

            area = PI * Math.Pow(r, 2);
            Console.WriteLine("Area do círculo = " + area.ToString("F3", CI));   
        }
    }
}