using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Dynamic
    {
        public static void Executar()
        {
            dynamic meuObejto = "teste"; //dynamic faz com que o tipo seja flexivel
            meuObejto = 3;
            meuObejto++;

            Console.WriteLine(meuObejto);

            dynamic aluno = new System.Dynamic.ExpandoObject(); //usando dynamic para objeto
            aluno.Nome = "Vitor";
            aluno.Nota = 10;
            aluno.Idade = 18;

            Console.WriteLine($"{aluno.Nome}, {aluno.Nota}, {aluno.Idade}");
        }
    }
}
