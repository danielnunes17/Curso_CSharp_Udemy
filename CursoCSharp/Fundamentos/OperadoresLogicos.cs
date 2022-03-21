namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            bool ExecutouTrabalho1 = false;
            bool ExecutouTrabalho2 = true;

            bool ComprouPresente = ExecutouTrabalho1 && ExecutouTrabalho2;
            Console.WriteLine("Comprou o presente? {0}", ComprouPresente);

            bool ComprouRoupa = ExecutouTrabalho1 || ExecutouTrabalho2;
            Console.WriteLine("Comprou a roupa? {0}", ComprouRoupa);

            bool ComprouTV = ExecutouTrabalho1 ^ ExecutouTrabalho2;
            Console.WriteLine("Comprou a tv de 32? {0}", ComprouTV);

            
        }
    }
}
