

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class UsandoPath
    {
        public static void Executar()
        {
            var arquivo = @"C:\exemplo_path.txt";
            var pasta = @"C:\exemplo_path_pasta";

            if (!Directory.Exists(arquivo))
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    sw.WriteLine("Consegui criar o arquivo");
                }
            }   
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));
            Console.WriteLine(Path.HasExtension(pasta));

        }
    }       
}
