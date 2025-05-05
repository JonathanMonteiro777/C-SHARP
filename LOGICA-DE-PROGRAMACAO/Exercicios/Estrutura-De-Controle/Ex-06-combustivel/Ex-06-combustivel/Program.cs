using System;

namespace Course
{
    public class Combustivel
    {
        static void Main(string[] args)
        {
            int codigo;
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            do
            {
                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());

                while (codigo < 1 || codigo > 4)
                {
                    Console.Write("Codigo invalido! Informe um codigo (1, 2, 3) ou 4 para parar:");
                    codigo = int.Parse(Console.ReadLine());
                }

                if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }
            }
            while (codigo != 4);

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}