namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            //Conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int NotaTruncada = (int) nota;
            //Usando Cash para conevrsão exlicita, cuidado com a perda de dados
            Console.WriteLine("Nota truncada: {0}" , NotaTruncada);

            Console.WriteLine("Digite sua idade");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            Console.WriteLine("Idade inserida {0}", idadeInt);

            idadeInt = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado {0}", idadeInt);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1 é: {0}", numero1);

            Console.WriteLine("Digite o segundo número: \n");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O Resultado 2 é: {0}", numero2);






        }
    }
}
