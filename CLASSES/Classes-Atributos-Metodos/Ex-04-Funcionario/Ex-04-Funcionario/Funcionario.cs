using System.Globalization;

namespace Ex_04_Funcionario
{
    class Funcionario
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CI);        }
    }
}
