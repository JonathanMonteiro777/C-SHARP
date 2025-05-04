using System;

namespace Course
{
    public class TempoDeJogo
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracaoFinal;

            Console.Write("Hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial > horaFinal)
            {
                duracaoFinal = 24 - horaInicial + horaFinal;

            }
            else if (horaInicial < horaFinal)
            {
                duracaoFinal = horaFinal - horaInicial;
            }
            else
            {
                duracaoFinal = 24;
            }

            Console.WriteLine($"O JOGO DUROU  {duracaoFinal} HORA(S)");
        }
    }
}