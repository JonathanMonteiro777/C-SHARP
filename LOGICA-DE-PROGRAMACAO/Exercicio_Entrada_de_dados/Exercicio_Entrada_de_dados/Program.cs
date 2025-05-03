using System;
using System.Globalization;

namespace Course
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto: ");
            double produto = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], culture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", culture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", culture)); 
        }
    }
}