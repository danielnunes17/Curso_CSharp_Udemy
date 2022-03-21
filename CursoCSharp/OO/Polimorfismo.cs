namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }

        public class Feijao : Comida //Relação de herança
        {
            public Feijao(double peso) : base(peso) { }
        }
        public class Arroz : Comida
        {
            public Arroz(double peso) : base(peso) { }
        }

        public class Carne : Comida
        {
            public Carne(double peso) : base(peso) { }
        }


        public class Pessoa
        {
            public double Peso;
            //3 métodos para 3 tipos de comida
            //public void Comer(Feijao feijao) 
            //{
            //    Peso += feijao.Peso;
            //}
            //public void Comer(Arroz arroz)
            //{
            //    Peso += arroz.Peso;
            //}

            //public void Comer(Carne carne)
            //{
            //    Peso += carne.Peso;
            //}
            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }

        public class Polimorfismo
        {
            public static void Executar()
            {
                Feijao Ingrediente1 = new Feijao(0.3);
                Arroz Ingrediente2 = new Arroz(0.5);
                Carne Ingrediente3 = new Carne(0.6);
              

                Pessoa Cliente = new Pessoa();
                Cliente.Peso = 80.2;
                Cliente.Comer(Ingrediente1);
                Cliente.Comer(Ingrediente2);
                Cliente.Comer(Ingrediente3);

                Console.WriteLine($"Agora o peso do Cliente é {Cliente.Peso} Kg!");

            }
        }
    }
}
