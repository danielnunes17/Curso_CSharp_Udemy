namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensaoInteiro
    {
        public static int Soma(this int num, int outronum) //Criando o metodo de extensão usando this
        {
            return num + outronum;
        }

        public static double Subtracao(this double num, double outronum)
        {
            return num - outronum;
        }
    }
    public class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numeroreal = 2.5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numeroreal.Subtracao(2.5));
            Console.WriteLine(2.Soma(3));
            Console.WriteLine(5.5.Subtracao(10));

            //O que importa aqui é o numero que vc quer extnder com a função usando o This

        }
    }
}
