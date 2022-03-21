namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var ValorNegativo = -5;
            int numero1 = 2;
            int numero2 = 3;
            bool Boleano = true;

            Console.WriteLine(- ValorNegativo);
            Console.WriteLine(!Boleano);

            numero1++;
            Console.WriteLine(numero1);

            numero1--;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1 ++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");


        }
    }
}
