namespace CursoCSharp.ClasseeMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Renato";
            fulano.Idade = 22;

            Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos");
        }
    }
}
