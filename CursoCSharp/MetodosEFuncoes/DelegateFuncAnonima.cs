namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateFuncAnonima
    {
        delegate string StringOperacao(string str);
        public static void Executar()
        {
            StringOperacao inverter = delegate (string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("Daniel é magro!!!" ));
        }
    }
}
