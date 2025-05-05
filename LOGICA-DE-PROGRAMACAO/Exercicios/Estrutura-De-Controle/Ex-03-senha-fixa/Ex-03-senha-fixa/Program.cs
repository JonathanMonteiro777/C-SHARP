using System;

namespace Course
{
    public class SenhaFixa
    {
        static void Main(string[] args)
        {
            int senha, senhaCorreta = 2002;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Senha Invalida! Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            while (senha != senhaCorreta);

            Console.WriteLine("Acesso permitido!");
        }
    }
}