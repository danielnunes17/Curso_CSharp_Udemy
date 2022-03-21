namespace CursoCSharp.ClasseeMetodos
{
    public class Dependente
    {
        public string Name;
        public int Age;
    }
    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;

            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Name = "Daniel",
                Age = 39,
              
            };

            Dependente Copiadep = dep;
            Console.WriteLine($"{dep.Name} {Copiadep.Name}");
            Console.WriteLine($"{dep.Age} {Copiadep.Age}");

            Copiadep.Name = "Ambrósio";
            Copiadep.Age = 21;

            Console.WriteLine($"{Copiadep.Name} {dep.Name}");
            Console.WriteLine($"{Copiadep.Age} {dep.Age}");

        }
    }
}
