namespace CursoCSharp.EstruturaDeControle
{
    internal class ForEach
    {
        public static void Executar()
        {
            var palavra = "Daniel";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "Ana", "Thais", "Lucrécia" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
