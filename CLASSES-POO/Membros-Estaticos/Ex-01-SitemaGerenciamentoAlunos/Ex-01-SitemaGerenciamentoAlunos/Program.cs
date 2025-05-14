using Ex_01_SitemaGerenciamentoAlunos;
using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o numero da matricula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Havera nota inicial do aluno (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite a nota inicial do aluno: ");
                double notaInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno = new Aluno(nome, matricula, notaInicial);
            }
            else
            {
                aluno = new Aluno(nome, matricula);
            }

            Console.WriteLine();
            Console.WriteLine("Dados do Aluno:");
            Console.WriteLine(aluno.ObterDadosCompletos());

            Console.WriteLine();
            Console.WriteLine("Adicionar nota do aluno:");
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.AdicionarNota(nota);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(aluno.ObterDadosCompletos());

            Console.WriteLine();
            Console.WriteLine("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.RemoverNota(nota);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(aluno.ObterDadosCompletos());
        }
    }
}