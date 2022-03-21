using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos() //método
        {
            Console.WriteLine("FilhoNaoReconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
           // Console.WriteLine(UsaMuitoPhotoshop); não é possivel acessar...
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAessos()
        {
            Console.WriteLine("Amigo disntante...");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos); não é possivel acessar
            //Console.WriteLine(amigo.NumeroCelular); não é possivel acessar pq é inernal
            //Console.WriteLine(amigo.JeitoDeFalar); não é possivel acessar pq é protcted
            //Console.WriteLine(amigo.SegredoDeFamilia); não é possivel acessar 
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);

        }
    }
    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade(); //Instaciando
            sub.MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAessos();



        }
    }
}
