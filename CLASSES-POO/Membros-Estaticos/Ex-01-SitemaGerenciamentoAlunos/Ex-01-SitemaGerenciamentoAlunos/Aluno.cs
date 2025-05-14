using System.Globalization;


namespace Ex_01_SitemaGerenciamentoAlunos
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; private set; }
        public List<double> Notas { get; private set; }

        public Aluno(string nome, int matricula) 
        {
            Nome = nome;
            Matricula = matricula;
            Notas = new List<double>();
        }
        public Aluno(string nome, int matricula, double notaInicial):this(nome, matricula) 
        {
            Notas.Add(notaInicial);
        }

        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }
        public void RemoverNota(double nota)
        {
            Notas.Remove(nota);
        }

        public  string ObterDadosCompletos()
        {
            if (Notas.Count == 0)
            {
                return $"Nome: {Nome}, Matrícula: {Matricula}, Notas: 0.00"; // Trata o caso de lista vazia
            }
            string notasString = string.Join(", ", Notas.ConvertAll(n => n.ToString("F2", CultureInfo.InvariantCulture))); // Formata as notas
            return $"Nome: {Nome}, Matrícula: {Matricula}, Notas: {notasString}";
        }
    }
}
