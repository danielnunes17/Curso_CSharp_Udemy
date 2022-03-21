namespace CursoCSharp.MetodosEFuncoes
{
    class LambdasDelegate
    {
        delegate double Operacao(double x, double y); //double é o tipo de retorno, Operacao é um tipo e tb o nome, posso criar variavel e parametros de funçao que usam o tipo Operacao

        public static void Executar()
        {
            Operacao som = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;
            Operacao div = (x, y) => x / y;

            Console.WriteLine(som(3, 3));
            Console.WriteLine(sub(10, 5));
            Console.WriteLine(mult(2, 5));
            Console.WriteLine(div(30, 3));

            //O delegate é um tipo, e podemos então criar variaveis com esse tipo, assinatura aqui é o tipo de parametro e o tipo de retorno que retornará a partir da função
        }
    }
}
