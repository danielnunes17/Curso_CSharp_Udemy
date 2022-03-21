namespace CursoCSharp.OO
{

    public class Carro
    {
        //Atributos encapsulado

        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        //método construtor

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        //método protegido só pode ser acessado por herança
        //Método encapsulado

        protected int AlterarVelocidade(int delta)

            {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;

            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;

            } else {
                 VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        //mais métodos
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }

     }

    //Classe que herda de carro

    public class Uno : Carro
    {
        //Tem que criar um construtor base que esperar receber a VelocidadeMaxima
        //Se houvesse construtor padão não precisaria criar o construtor base que está definido na classe Pai
        public Uno() : base(200)
        {

        }
    }
    //Criando mais uma...
    public class Ferrari : Carro
    {
        public Ferrari() : base(350){
        }
        //Sobrescrevendo o método acelerar é necessário manter a compatibilidade entre os
        //métodos
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }
        //Ocultando o método da classe Pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            //recebeu o método por herança
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());

            //Usando Polimorfismo
            Console.WriteLine("Uno com tipo Carro");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());


        }
    }
}

