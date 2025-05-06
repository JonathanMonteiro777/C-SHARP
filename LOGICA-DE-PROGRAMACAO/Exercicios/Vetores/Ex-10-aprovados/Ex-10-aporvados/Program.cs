using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    public class Aprovados
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos alunos serao digitados? ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            // lista para armazenar os alunos aprovados
            List<string> alunosAprovados = new List<string>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Digite nome, primeira e segunda nota do {i + 1}o aluno:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Primeira nota: ");
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Segunda nota: ");
                nota2[i] = double.Parse(Console.ReadLine(), CI);

                double media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6.0)
                {
                    // Adiciona o nome à lista de aprovados
                    alunosAprovados.Add(nomes[i]); 
                }
            }

            // Chamando a função para mostrar os aprovados
            MostrarAprovados(alunosAprovados); 
        }

        // Função para mostrar os alunos aprovados
        static void MostrarAprovados(List<string> aprovados)
        {
            Console.WriteLine("\nAlunos aprovados:");
            foreach (string nome in aprovados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}