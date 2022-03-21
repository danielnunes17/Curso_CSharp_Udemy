namespace CursoCSharp.EstruturaDeControle
{
    internal class While
    {
        public static void Executar()
        {
            int palpite = 0;    
            Random random = new Random();

            int numeroSecreto = random.Next(1, 10);
            bool numeroEncontrado = false;
            int tentativasRestantes = 10;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;
            }

            if (numeroSecreto == palpite)
            {
                numeroEncontrado = true;
                var corAnterior = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                Console.BackgroundColor = corAnterior;
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("Menor...tente novamente!");
                Console.WriteLine("Tentantivas restantes: {0}", tentativasRestantes);

            }
            else
            {
                Console.WriteLine("Maior...tente novamente!");
                Console.WriteLine("Tentativas restante: {0}", tentativasRestantes);
            }
        }
    }
}
