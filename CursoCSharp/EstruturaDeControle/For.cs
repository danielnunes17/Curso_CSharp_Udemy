namespace CursoCSharp.EstruturaDeControle
{
    internal class For
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Digite quantos alunos há na turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 0; i < tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio = +notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Média da turma {0}", media);
                

        } 
    }
}
