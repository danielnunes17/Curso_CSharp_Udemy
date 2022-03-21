namespace CursoCSharp.ClasseeMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar a varialvel a dentro do método executar
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

        }
    }
}
