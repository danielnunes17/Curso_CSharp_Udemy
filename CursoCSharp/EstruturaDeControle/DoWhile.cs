namespace CursoCSharp.EstruturaDeControle
{
    internal class DoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Digite seu nome: ");
                entrada = Console.ReadLine(); 
                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("Você deseja continuar? [S/N] ");
                entrada = Console.ReadLine();

            }while(entrada.ToLower() == "s");
            Console.WriteLine("Até mais!!!");
        }
          
    }
}
