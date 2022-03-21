namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Uma odiceia no espaço");
            filmes.Add(1985, "O cemitério maldito");
            filmes.Add(1995, "Jamaica abaixo de zero");
            filmes.Add(2022, "Spider man, de volta pra casa");

            if (filmes.ContainsKey(2000))
            {
                Console.WriteLine("2000: " + filmes[2000]);
                Console.WriteLine("2000: " + filmes.GetValueOrDefault(2000));
            }

            Console.WriteLine(filmes.ContainsValue("Jamaica"));
            Console.WriteLine($"Removey? {filmes.Remove(1985)} ");

            filmes.TryGetValue(2022, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach( var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"O {filme.Value} é de {filme.Key}!!!");
            }

            foreach(var filme in filmes)
            {
                Console.WriteLine($"O {filme.Value} é de {filme.Key}!!!");
            }
        }

    }
}
