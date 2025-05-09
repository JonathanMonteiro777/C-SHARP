

namespace Ex_ContadorDeInstancias
{
    class Contador
    {
        private static int TotalInstancias = 0;

        public Contador()
        {
            TotalInstancias++;
            Console.WriteLine("Nova instancia criada.");
        }
        public static int ObterTotalInstancias()
        {
            return TotalInstancias;
        }
    }
}
