using System;

namespace Course
{
    public class Tabuada
    {
        static void Main(string[] args)
        {
            int N, res = 0;

            Console.Write("Deseja a tabuada para qual valor? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                res = N * i;
                Console.WriteLine($"{N} x {i} = {res}");
            }
        }
    }
}