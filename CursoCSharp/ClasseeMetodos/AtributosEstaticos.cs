namespace CursoCSharp.ClasseeMetodos
{

    public class Produto
    {

        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()
        {

        }
        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    public class AtributosEstaticos
    {
        public static void Executar()
        {   
            var Produto1 = new Produto("Caneta", 5.50, 0.1);
            
            var Produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.60,
                Desconto = 0.2,
            };
            Console.WriteLine("Preço com desconto {0}", Produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}", Produto2.CalcularDesconto());
        }
    }

}
       

