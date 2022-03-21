namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "PC gamer";
            string marca = "Samsung";
            double preco = 7500.00;

            Console.WriteLine("O " + nome + " " + "da marca " + marca + " " + "é bom e custa" +
                " " + "R$" + preco + ".");
            Console.WriteLine("O {0} da marca {1} é bom e custa R$ {2}.",
            nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} é bom e custa R$ {preco}");



        }
    }
}
