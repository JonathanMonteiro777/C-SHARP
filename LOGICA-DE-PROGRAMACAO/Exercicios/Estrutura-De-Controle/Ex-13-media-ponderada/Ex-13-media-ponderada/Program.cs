using System;
using System.Globalization;

namespace Course
{
    public class MediaPonderada
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            double num1, num2, num3, media;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite tres numeros:");
                num1 = double.Parse(Console.ReadLine(), CI);
                num2 = double.Parse(Console.ReadLine(), CI);
                num3 = double.Parse(Console.ReadLine(), CI);

                media = (num1 * 2.0 + num2 * 3.0 + num3 * 5.0) / 10.0;
                Console.WriteLine($"MEDIA = {media.ToString("F1", CI)}");
            }
        }
    }
}