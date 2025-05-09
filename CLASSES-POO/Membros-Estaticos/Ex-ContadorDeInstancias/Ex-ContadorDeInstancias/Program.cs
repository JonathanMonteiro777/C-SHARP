using Ex_ContadorDeInstancias;
using System;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contador cont1 = new Contador();
            Contador cont2 = new Contador();
            Contador cont3 = new Contador();

            Console.WriteLine($"Total de Instancias criadas: {Contador.ObterTotalInstancias()}");
        }
    }
}