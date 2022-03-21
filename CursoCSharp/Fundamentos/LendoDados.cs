using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        static public void Executar()
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua renda mensal?");
            double renda = double.Parse(Console.ReadLine(),
               CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${renda}");
        }
    }
}
