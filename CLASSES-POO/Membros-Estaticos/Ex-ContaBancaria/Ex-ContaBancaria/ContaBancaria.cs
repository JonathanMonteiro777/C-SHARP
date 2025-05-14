using System.Globalization;

namespace Ex_ContaBancaria
{
    internal class ContaBancaria
    {
        // Atributos
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get;  private set; }
        
        // Construtores
        public ContaBancaria(int numero, string titular) 
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        // Metodos de deposito e saque
        public void Deposito(double quantia) 
        {
            Saldo += quantia;
        }

        public void Saque(double quantia) 
        {
            Saldo -= quantia + 5.0;
            
        }
        
        public override string ToString()
        {
            return "Conta "
                + Numero 
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
