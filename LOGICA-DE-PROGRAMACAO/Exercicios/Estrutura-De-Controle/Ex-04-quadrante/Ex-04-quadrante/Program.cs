using System;

namespace Course
{
    public class Quadrante
    {
        static void Main(string[] args)
        {
            int X, Y;

            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            do
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("QUADRANTE Q1");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("QUADRANTE Q2");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("QUADRANTE Q3");
                }
                else
                {
                    Console.WriteLine("QUADRANTE Q4");
                }

                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
            }
            while (X != 0 && Y != 0);
        }
    }
}