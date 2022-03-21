

namespace CursoCSharp.Api
{
    public class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo= new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }

        }
        public static void Executar()
        {
            var CaminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var CaminhoDestino = @"~/arq_destino.txt".ParseHome();
            var CaminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(CaminhoOrigem, CaminhoDestino, CaminhoCopia);

            using(StreamWriter sw = File.CreateText(CaminhoOrigem))
            {
                sw.WriteLine("Arquivo Original");
            }
            FileInfo origem = new FileInfo(CaminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(CaminhoCopia);
            origem.MoveTo(CaminhoDestino);
        }
    }
}
