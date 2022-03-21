namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => //O parentese é para adicionar o parametro, a função é o que está depois do =
            //Aqui temos uma função anonima (Labda) que está sendo armazenada na variavel algoNoConsole que é do tipo Action. Action é uma função void, não tem retorno
            {
                Console.WriteLine("Lambda no C#");
            };
                algoNoConsole(); //invocando

            Func<int> jogarDado = () =>  //int é o tipo de retorno da Func
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            //Recebe o int como parametro e vai retornar a string, numero é o parametro que vai receber dessa função
            //Quando uso => o retorno está implicito, quando tem apenas um parametro não precisa do (), se tem apenas uma sentença nçao precisa das {}
            //função numero => numero.ToString("X"); está armazenada dentro da variavel conversorHex
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
                Console.WriteLine(formatarData(17, 11, 1982));
        }
    }
}
