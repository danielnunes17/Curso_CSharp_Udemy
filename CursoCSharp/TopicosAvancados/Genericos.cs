using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T> //Declarando o tipo "T"
    {
        T valorPrivado; //Atributo do tipo T
        public T Coisa { get; set; } // Propriedade do tipo T
        public Caixa(T coisa) //tipo genérico T para um construtor O "T" é algo que será subistituido depois
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) //Criando um método genérico que retorna um tipo T
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() //Outro método que retorna o tipo T
        {
            return valorPrivado;
        }

    }

    class CaixaInt : Caixa<int> //No momento da herança define o tipo genérico, todo "T" será substituido pelo valor Int
    {
        public CaixaInt() : base(0)
        {

        }

    }
   public  class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000); //Quando instaciar uma classe, tudo que chamar de Caixa será Int
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType()); //system.int32 pq a partir do generics consego amarrar o tipo 

            var caixa2 = new Caixa<string>("Construtor"); //mudando para string, valor T sendo substituido pelo valor que coloquei dentro do generics, tanto a partir da herança quanto na instancialção do ogjeto é necessário declarar o tipo
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());
        }
    }
}
