using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~PastaNova".ParseHome();
            var novoDirDestino = @"~PastaNovaDestino".ParseHome();
            var dirProjeto = @"C:\Work\UDEMY\Csharp\CursoCSharp\CursoCSharp";

            if (Directory.Exists(novoDir)) //Métodos estáticos, não foi necessário fazer uma instancia
            {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("===========Pastas===========");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n \n ===========Arquivos=========");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n=========Raiz========");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
