namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override bool Equals(object obj)
           
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome; 
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    
    internal class List
    {
        public static void Executar()
        {
            var livro = new Produto("Senhor dos anéis", 99.50);

            var carrinho = new List<Produto>();
        
                carrinho.Add(livro);

            var combo = new List<Produto>
            {
            new Produto("Chinelo", 30.50),
            new Produto("Camisa", 45.70),
            new Produto ("Boné", 25.50),

            };
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} R${item.Preco}");

            }


        }
        
    }
 

}    

