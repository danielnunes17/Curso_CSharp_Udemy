namespace CursoCSharp.ClasseeMetodos
{

    class CalculadoraComum
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }
        public double Subtrair(double a, double b)
        {
            return a - b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public double Dividir(double a, double b)
        {
            return a / b;
        }

    }

    class CalculadoraCadeia
    {
        double memoria;
        
        public CalculadoraCadeia Somar (double a)
        {
            memoria = a;
            return this;
        }

        public CalculadoraCadeia Multiplicar (double a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Print()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public double Result()
        {
            return memoria;
        }
    }
    public class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(15, 20));

            var CalculadoraCadeia = new CalculadoraCadeia();
            CalculadoraCadeia.Somar(3.5).Multiplicar(3.5).Print().Limpar().Print();

            resultado = CalculadoraCadeia.Somar(4.5).Multiplicar(2.5).Result();
            Console.WriteLine(resultado);
        }
    }
}
