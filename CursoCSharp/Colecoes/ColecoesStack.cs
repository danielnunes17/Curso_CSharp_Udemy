using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push("Avião");
            pilha.Push(3);
            pilha.Push(true);
            pilha.Push(4.3f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");

        }
            

    }
}
