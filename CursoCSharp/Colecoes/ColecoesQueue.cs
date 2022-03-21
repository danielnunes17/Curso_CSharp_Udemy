using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Josias");
            fila.Enqueue("Sebastian");
            fila.Enqueue("Karla");
            fila.Enqueue("Tatiana");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            //para tirar da lista

            //Console.WriteLine(fila.Dequeue());
            //Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);  
            }

            var salada = new Queue();

            salada.Enqueue("Alface");
            salada.Enqueue(2);
            salada.Enqueue(true);
            salada.Enqueue(5.2);
            Console.WriteLine(salada.Peek());
            Console.WriteLine(salada.Contains(2));
        }
    }
}
