namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota");
            double.TryParse(Console.ReadLine(), out double nota);
            double NotadeCorte = 7.0;

            Console.WriteLine("Você tirou total! Parabéns", nota == 10);
            Console.WriteLine("Você reprovou", nota < NotadeCorte);
            Console.WriteLine("Você passou! Parabéns", nota > NotadeCorte);

        }
    }
}
