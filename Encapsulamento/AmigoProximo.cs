namespace Encapsulamento
{
    public class AmigoProximo
    {
        //instacia/referencia para classe SubCelebridade relação de composição

        public readonly SubCelebridade amigo = new SubCelebridade();
        public new void MeusAcessos()
        {
            Console.WriteLine("Amigo próximo...");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos); não é possivel acessar
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoDeFamilia); não é possivel acessar 
           //Console.WriteLine(amigo.UsaMuitoPhotoshop);
            
        }
    }
}
