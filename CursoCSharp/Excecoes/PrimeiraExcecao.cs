namespace CursoCSharp.Excecoes
{
    public class ContaCorrente
    {
        double Saldo;

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente"); //Com Throw estamos lançando uma exceção, ArgumenrException é uma palavra reservada especifica
            }
            Saldo -= valor; // se não entrar na exceção, subtrai o valor para que o saque possa acontecer -= atribuição subtrativa
        }
    }
    public class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new ContaCorrente(1_233.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque efetuado com sucesso!!!");

            }catch (Exception ex) //Exception é uma palavra reservada genérica, essa é a mãe das exceções
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!!!");
            }
        }
        
    }
}
