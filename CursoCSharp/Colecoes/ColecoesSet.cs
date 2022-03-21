namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Senhor dos anéis", 99.50);

            var carrinho = new HashSet<Produto>();
        
                carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
            new Produto("Chinelo", 30.50),
            new Produto("Camisa", 45.70),
            new Produto ("Boné", 25.50),

            };
            carrinho.UnionWith(combo);
            //Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} R${item.Preco}");

            }


        }
        
    }
 

}    

