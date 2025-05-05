using System;
using System.Globalization;

namespace Course
{
    public class MediaIdades
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double idade, media, soma = 0;
            int cont = 0;

            Console.WriteLine("Digite as idades:");
            idade = double.Parse(Console.ReadLine(), CI);

            while (idade > 0)
            {
                soma += idade;
                cont++;

                idade = double.Parse(Console.ReadLine(), CI);
            }
            if (cont > 0)
            {
                media = soma / cont;
                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            } else
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }

        }
    }
}