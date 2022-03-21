namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Atributo acessivel a todos
        public string InfoPublica = "Tenho um Instagram";

        //Atributo Portected acessivel por herança
        protected string CorDosOlhos = "Castanho";

        //Mesmo projeto (mesmo Assembly) usando Ulong (não tem sinal)
        internal ulong NumeroCelular = 553199999999;

        //Herança ou no mesmo projeto

        protected internal string JeitoDeFalar = "Uso várias girias";

        //Mesma classe ou herança do mesmo projeto
        private protected string SegredoDeFamilia = "Várias tretas";

        //Valor padrão Private

        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }




    }
}
