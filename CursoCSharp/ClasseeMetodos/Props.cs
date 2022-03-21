namespace CursoCSharp.ClasseeMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        public string Nome
        {
            get {return "Opcional: " + Nome;}
            set { Nome = value; }
        }

        //Propriedade autoimplementada

        public double Preco { get; set; }

        //Somente leitura

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
     class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 4.200);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção elétrica";
            op2.Preco = 4.500;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
