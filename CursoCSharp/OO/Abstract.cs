namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar()
        {
            return "Trim...Trim...";
        }
    }

    public class Samsung : Celular // classe concreta ele recebe o método Tocar por herança, mas assistente tenho que instaciar
    {
        public override string Assistente()
        {
            return "Olá meu nome é Laxerguinasse";
        }
    }

    public class IPhone : Celular //classe concreta
    {
        public override string Assistente()
        {
            return "Olá eu sou a Siri";
        }
    }
     class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>()
            {
                new IPhone(),
                new Samsung()
            };
            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }

    }
}
