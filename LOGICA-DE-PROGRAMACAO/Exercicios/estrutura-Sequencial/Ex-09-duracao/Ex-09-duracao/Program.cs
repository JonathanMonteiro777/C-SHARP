using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int  totsegundos;

            Console.Write("Digite a duracao em segundos:");
            totsegundos = int.Parse(Console.ReadLine());

            int horas = totsegundos / 3600;
            int segundosrestantes = totsegundos % 3600;
            int minutos = segundosrestantes / 60;
            int segundos = segundosrestantes % 60;

            Console.WriteLine(horas+ ":" +minutos+ ":" +segundos);
        }
    }
}