namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool comportamento = true;
            string resultado = nota >= 7.0 && comportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
