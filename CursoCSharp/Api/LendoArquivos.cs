namespace CursoCSharp.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new File.AppendText(path)); //metódo isposable que é a liberação do recurso pra usar um bloco using é necessário passar como argumento do bloco using algo que implemente essa interface, tem que ser um tipo que implemente a interface IDisposable
                {
                    sw.WriteLine("Produto; Preço; Quantidade");
                    sw.WriteLine("Caneta Bic; Preta; 3.50; 98");
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message());
            }
        }
    }
}
