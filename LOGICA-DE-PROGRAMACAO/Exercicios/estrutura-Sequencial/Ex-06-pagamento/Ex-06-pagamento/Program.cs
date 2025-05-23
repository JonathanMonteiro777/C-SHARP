﻿using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double valorHora, pagamento;
            int horasTrabalhadas;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine());
            Console.Write("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            pagamento = valorHora * horasTrabalhadas;
            Console.WriteLine("O pagamento para " + nome + " deve ser " + pagamento.ToString("F2", CI));

        }
    }
}