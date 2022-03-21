using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var directProjeto = "C:\teste"; 

            var dirInfo = new DirectoryInfo(directProjeto);
            //try
            //{
            //    dirInfo.Create();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            if (dirInfo.Exists)
            {
                dirInfo.Create(); //Chamando funções de instancia, diferente do Directory que são funções estaticas
            }
            Console.WriteLine("========Arquivos=======");
            var arquivos = dirInfo.GetFiles(); //não precisa passar nada no parentese pq ja estamos pegando direto da instacia que saber qual o diretório que esta apontando

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("=========Pastas========");
            var pastas = dirInfo.GetDirectories();

            foreach (var pasta in pastas) ;
            Console.WriteLine(pastas);
        }
    }
}
