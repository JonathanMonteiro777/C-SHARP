using System;

namespace Course
{
    public class SequenciaImpares
    {
        static void Main(string[] args)
        {
            int X;

            Console.Write("Digite o valor de X: ");
            X = int.Parse(Console.ReadLine());

            for (int i = 1; i < X; i++)
            {
                if (i %2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}