namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool BomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("O aluno possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            BomComportamento = entrada.ToLower() == "s";
            if (nota >= 9.0 && BomComportamento) ;
            Console.WriteLine("Você entrou para o quadro de honra da escola");


        }
    }
}
