namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Você entrou para o quadro de melhores alunos");
            }else if (nota >= 7.0)
            {
                Console.WriteLine("Você está de recuperação");

            }else if (nota <= 5.0)
            {
                Console.WriteLine("Você está reporvado");
            }
            else
            {

                Console.WriteLine("Nota insuficiente");
            }
            Console.WriteLine("Até mais...");
        }
    }
}
