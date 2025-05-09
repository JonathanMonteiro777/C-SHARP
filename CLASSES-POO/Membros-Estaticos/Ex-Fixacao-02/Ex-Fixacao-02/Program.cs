using Ex_Fixacao_02;
using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Digite o nome do titular da conta: ");
            conta.Titular = Console.ReadLine();
            Console.Write("Digite o saldo inicial da conta: ");
            conta.Saldo = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Dados da conta: {conta}");

            ExibirMenu(conta);

        }

        static void ExibirMenu(ContaBancaria conta)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int opcao;

            do
            {
                Console.WriteLine("\nOpcoes:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Calcular Juros");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a opcao: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor do deposito: ");
                        double valorDeposito = double.Parse(Console.ReadLine(), CI);
                        conta.Depositar(valorDeposito);
                        Console.WriteLine($"Novo saldo: {conta.Saldo.ToString("F2", CI)}");
                        break;
                    case 2:
                        Console.Write("Digite o valor do saque: ");
                        double valorSaque = double.Parse(Console.ReadLine(), CI);
                        conta.Sacar(valorSaque);
                        Console.WriteLine($"Novo saldo: {conta.Saldo.ToString("F2", CI)}");
                        break;
                    case 3:
                        Console.Write("Digite o valor para calcular os juros: ");
                        double valorJuros = double.Parse(Console.ReadLine(), CI);
                        double juros = ContaBancaria.CalcularJuros(valorJuros);
                        Console.WriteLine($"Juros: {juros.ToString("F2", CI)}");
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa.");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }

            }
            while (opcao != 0);
            Console.WriteLine("Dados da conta: " + conta);
        }
    }
}