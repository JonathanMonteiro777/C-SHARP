using System;
using System.Globalization;

namespace Course
{
    public class Aumento
    {
         static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double salario, novoSalario, aumento;
            int porcentagem;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), CI);

            if (salario <= 1000.00)
            {
                porcentagem = 20;
                aumento = salario * 0.20;
                novoSalario = salario + aumento;
            }
            else if (salario <= 3000.00)
            {
                porcentagem = 15;
                aumento = salario * 0.15;
                novoSalario = salario + aumento;
            }
            else if (salario <= 8000.00)
            {
                porcentagem = 10;
                aumento = salario * 0.10;
                novoSalario = salario + aumento;
            }
            else
            {
                porcentagem = 5;
                aumento = salario * 0.05;
                novoSalario = salario + aumento;
            }
            Console.WriteLine("Novo salario = R$ " + novoSalario.ToString("F2", CI));
            Console.WriteLine("Aumento = R$ " + aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + porcentagem + " %");
            
       
        }
    }
}