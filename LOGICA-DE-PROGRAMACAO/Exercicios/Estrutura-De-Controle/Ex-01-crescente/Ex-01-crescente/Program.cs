using System;

namespace Course
{
    public class Crescente
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite dois numeros:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine("DECRESCENTE!");
                }
                else
                {
                    Console.WriteLine("CRESCENTE!");
                }

                Console.WriteLine("Digite outros dois numeros:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            }
        }
    }
}