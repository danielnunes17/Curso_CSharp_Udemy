namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];

            alunos[0] = "Daniel";
            alunos[1] = "Vitor";
            alunos[2] = "Mayara";
            alunos[3] = "Ivani";
            alunos[4] = "Daniel";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.2, 8.5, 7.0, 6.5, 8.9 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for(int i = 0; i < alunos.Length; i++)
           // {somatorio += notas[i];}
                
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
            

        }
    }
}
