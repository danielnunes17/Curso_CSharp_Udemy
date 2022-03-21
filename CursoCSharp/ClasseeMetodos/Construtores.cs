namespace CursoCSharp.ClasseeMetodos

{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;    
            Fabricante = fabricante;   
            Ano = ano;  
        }
        public Carro()
        {

        }
    }
      internal class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "Monza";
            carro1.Fabricante = "GM";
            carro1.Ano = 1990;

            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("Celta", "GM", 2007);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");



        }
    }
}
