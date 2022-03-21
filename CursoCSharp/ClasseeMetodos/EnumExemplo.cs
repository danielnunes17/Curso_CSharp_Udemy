namespace CursoCSharp.ClasseeMetodos
{

    public enum Genero { Animacao, Comedia, Aventura, Terror, Trash, Doc };
        public class Filme
        {
        public string Titulo;
        public Genero GeneroDoFilme;
        }
        class EnumExemplo { 
    
        public static void Executar()
        {
            int id = (int)Genero.Aventura;
            Console.WriteLine(id);

            var filmePraFamilia = new Filme();
            filmePraFamilia.Titulo = "Os trapalhões";
            filmePraFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmePraFamilia.Titulo, filmePraFamilia.GeneroDoFilme);

        }
    }
}
