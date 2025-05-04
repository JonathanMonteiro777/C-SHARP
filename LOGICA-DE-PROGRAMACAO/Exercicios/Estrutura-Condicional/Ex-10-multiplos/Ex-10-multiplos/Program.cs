using System;
using System.Globalization;

namespace Course
{
    public class Multiplos
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite dois numeros inteiro:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}