namespace CursoCSharp.Excecoes
{
    public class NegativoException : Exception //relação "é-um" NegativoExcepiton é uma exceção, que está herando Exception da System
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
        //Uma exceção pode ter outra exceção como causa - Exceprion inner
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base (message) { }
    }

    public class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30 , 30);

            if(valor < 0)
            {
                throw new NegativoException("Número negativo...:(");
            }
            if(valor % 2 == 1)
            {
                throw new ImparException("Número ímpar...:(");
            }
            return valor;
        }
        public static void Executar()
        {
            try //Associado a um único try, personalizamos as exceções
            {
                Console.WriteLine(PositivoPar());
            }catch(NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
