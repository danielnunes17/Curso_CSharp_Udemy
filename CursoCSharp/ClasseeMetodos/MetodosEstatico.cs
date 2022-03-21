namespace CursoCSharp.ClasseeMetodos
{

    public class CalculadoraEstatica
    {
        //Metodo de Classe ou método estático
        public static double Somar(double a, double b)
        {
            return a + b;
        }
        //Metodo de Instancia ou membro de objeto
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
    }
        public class MetodosEstaticos
        {
            public static void Executar()
            {
                var resultado = CalculadoraEstatica.Somar(2.0, 2.5);
                Console.WriteLine("Resulato: {0}", resultado);
            }
           

        }
    
}
