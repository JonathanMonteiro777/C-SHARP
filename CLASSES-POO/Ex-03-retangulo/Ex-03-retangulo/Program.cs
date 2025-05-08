using Ex_03_retangulo;
using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CI);
            ret.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"AREA = {ret.Area().ToString("F2", CI)}");
            Console.WriteLine($"PERIMETRO = {ret.Perimetro().ToString("F2", CI)}");
            Console.WriteLine($"DIAGONAL = {ret.Diagonal().ToString("F2", CI)}");
        }
    }
}