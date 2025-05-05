using System;
using System.Globalization;

namespace Course
{
    public class Divisao
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, num1, num2;
            double res;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Entre com o numerador: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Entre com o denominador: ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 < 0)
                {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                else
                {
                    res = (double)num1 / num2;
                    Console.WriteLine($"DIVISAO = {res.ToString("F2", CI)}");
                }
            }
        }
    }
}