using Ex_04_Funcionario;
using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salario em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CI);
            func.AumentoSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados autalizados: " + func);
        }
    }
}