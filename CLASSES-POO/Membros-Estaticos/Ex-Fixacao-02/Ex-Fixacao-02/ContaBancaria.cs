using System.Globalization;

namespace Ex_Fixacao_02
{
    class ContaBancaria
    {
        // Atributos
        public string Titular;
        public double Saldo;

        CultureInfo CI = CultureInfo.InvariantCulture;

        // Membro estatico
        public static double TaxaDeJuros = 0.05;

        // Metodo
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        

        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        // Metodo estatico
        public static double CalcularJuros(double valor)
        {
            return valor * TaxaDeJuros;
        }

        public override string ToString()
        {
            return "\nTitular: " + Titular + "\nSaldo: " + Saldo.ToString("F2", CI);
        }
    }
}
