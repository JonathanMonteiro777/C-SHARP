using System;
namespace EstruturasDeControle
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.WriteLine("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                Console.WriteLine("Boa tarde!");
            }
        }
    }
}