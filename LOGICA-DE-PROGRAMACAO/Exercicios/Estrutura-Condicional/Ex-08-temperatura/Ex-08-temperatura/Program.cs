using System;
using System.Globalization;

namespace Course
{
    public class Temperatura
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            string escala;
            double fahrenheit, celsius, resultado;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            escala = Console.ReadLine().ToUpper(); // Converter para maiúscula


            if (escala == "F")
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine(), CI);
                celsius = (5.0 / 9.0) * (fahrenheit - 32.0);
                Console.WriteLine($"Temperatura equivalente em Celsius: {celsius.ToString("F2", CI)}");
            }
            else if (escala == "C")
            {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CI);
                fahrenheit = (9.0 / 5.0) * celsius + 32.0;
                Console.WriteLine($"Temperatura equivalente em Fahrenheit: {fahrenheit.ToString("F2", CI)}");
            }
            else
            {
                Console.WriteLine("Escala de temperatura invalida!");
            }
        }
    }
}