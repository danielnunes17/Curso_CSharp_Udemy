namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegatesParametro
    {
        public delegate int Operacao(int x, int y);
        public static int soma(int x, int y) //Como soma tem os mesmo parametros do delegate posso usar mesmo sem haver vinculação
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y) // a função calculadora foi a responsavel em invocar a função na linha 19
        {
            var resultado = op(x, y);
            return "resultado: " + resultado;
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3, 2));

            Console.WriteLine(Calculadora(soma, 3 , 2));
        }
    }
}
