namespace CursoCSharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria //Implementa a interface OperacaoBinaria
    {
        public int Operacao(int a, int b) // o membro de uma interface obrigatóriamente tem que ser public
        {
            return a + b;   
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multipliccao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }

    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multipliccao()
        };
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";
            foreach (var op in operacoes)
            {
                resultado += $"Usando{op.GetType().Name}" +
                    $" = {op.Operacao(a , b)}\n";
            }
            return resultado;   
        }
    }
    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
