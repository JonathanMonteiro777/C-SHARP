using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
         string produto1 = "Computador";
         string produto2 = "Mesa de escritorio";

         byte idade = 30;
         int codigo = 5290;
         char genero = 'M';

         double preco1 = 2100.0;
         double preco2 = 650.50;
         double medida = 53.234567;

         Console.WriteLine("Produtos:");
         Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto1, preco1);
         Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
         Console.WriteLine();
         Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: {genero}");
         Console.WriteLine();
         Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
         Console.WriteLine($"Arrendondamento (tres casas decimais): {medida:F3}");
         Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


    }
}