﻿namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com notas de 1 a 5: \n");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Exelente");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;

            }
            Console.WriteLine("Fim da pesquisa");
        }
    }
}