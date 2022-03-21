namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
          
            Console.WriteLine("Digite sua nota: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
