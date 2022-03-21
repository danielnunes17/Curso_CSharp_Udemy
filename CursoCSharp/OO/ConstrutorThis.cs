namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; } //Atributo
        public Animal(string nome) //construtor
        {
            Nome = nome;
        }

    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; } //Atributo

        public Cachorro (string nome) : base(nome) //primeiro construtor explicito
        {
            Console.WriteLine($"Cachorro {nome} foi inicializado"); //Chachorro sendo instaciado
        }
        public Cachorro(string nome, double altura) : this(nome) //Segundo construtor Chamando o construtor da própria classe, usando o this para chamar o construtor local
        {
            Altura = altura;    //altura é o atributo que está dentro de Cachorro
        }

        public override string ToString() //Transformando uma estnacia em uma string com o ToString
        {
            return $"{Nome} tem {Altura}cm de altura!!!";
        }
    }
    internal class ConstrutorThis
    {
        public static void Executar()
        {
            var chocolate = new Cachorro("Chocolate", 19);
            var max = new Cachorro("Max", 40);

            Console.WriteLine(chocolate); //passando o obejeto que será convertido
            Console.WriteLine(max);
        }
    }
}
