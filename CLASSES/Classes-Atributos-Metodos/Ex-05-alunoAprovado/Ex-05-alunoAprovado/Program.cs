using Ex_05_alunoAprovado;
using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CI));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltam {aluno.NotaRestante().ToString("F2", CI)} PONTOS");
            }
        }
    }
}