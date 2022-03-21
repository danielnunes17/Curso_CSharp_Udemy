namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;

            Console.WriteLine("O valor da Área é: " + area);

            bool estaChovendo = true;
            Console.WriteLine("está chvendo mesmo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Minha idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O Saldo é: " + saldoDeGols);

            short salario = short.MinValue;
            short salario2 = short.MaxValue;
            Console.WriteLine("O menor salário é : " + salario);
            Console.WriteLine("O maior Salário é: " + salario2);

            int menorValorint = int.MinValue;
            int maiorValorint = int.MaxValue;
            Console.WriteLine("O menor valor de um inteiro é: " + menorValorint);
            Console.WriteLine("O maior valor de um inteiro é: " + maiorValorint);

            uint populacaoDoBrasil = 207_000_000;
            Console.WriteLine("A população do Brasil em 2022 é: " + populacaoDoBrasil);

            long menorVarLong = long.MinValue;
            long maiorVarLong = long.MaxValue;
            Console.WriteLine("A variável Long tem o tamanho " +
                "de: " + menorVarLong + " bytes " + "até " + maiorVarLong);

            float precoPc = 12000.00f;
            Console.WriteLine("O preço do computador está caro: " + precoPc);

            double valorDeMercado = 10000000000.00;
            Console.WriteLine("O valor de mercado da Apple é: " + valorDeMercado);

            decimal distanciaDaTerra = decimal.MaxValue;
            decimal distanciaDaTerra2 = decimal.MinValue;
            Console.WriteLine("O maior valor da variavel decimal é: " + distanciaDaTerra
                + "e o menor é: " + distanciaDaTerra2);

            char letra = 'B';
            Console.WriteLine("Não se esqueça que o char, deve ser colocado com 'aspas' simples" +" " + letra);

            string texto = "A estring recebe um texto";
            Console.WriteLine(texto);




        }
    }
}
