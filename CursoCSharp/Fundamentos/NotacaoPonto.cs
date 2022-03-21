namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Ola".ToUpper().Insert(3, " Mundo!").Replace("Mundo", "World");
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

            Console.WriteLine("Teste".Length);
        }
    }
}
