namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //preço com desconto

            Console.WriteLine("Digite o preço");
            var preco = double.Parse(Console.ReadLine());
            var imposto = 0.03;
            var desconto = 0.1;

            double total = preco + imposto;
            double totalComDesconto = total - (total * desconto);
            Console.WriteLine("Preço final é: {0}", totalComDesconto);

            //IMC

            Console.WriteLine("Digite seu peso");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu IMC é: {IMC}");

            //Par ou impar

            int par = 20;
            int impar = 55;
            Console.WriteLine("O {0}/2 tem resto{1}", par, par %2);
            Console.WriteLine("O{0}/2 tem resto {1}", impar, impar % 2);






        }
    }
}
