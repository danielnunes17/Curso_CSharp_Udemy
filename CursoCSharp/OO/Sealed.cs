namespace CursoCSharp.OO
{

    class SemFilho
    {
        public double ValorFortuna()
        {
            return 1_400_535_00;
        }
    }
    class Avo
    {
        public virtual bool HonrarFamila()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarFamila()
        {
            return true ;
        }
    }

    //class Filho : Pai
    //{
    //    //public override bool HonrarFamilia() // override Não consegue sobrescrever para false pq o método está selado
    //        //O new bool vai ocultar o método
    //    {
    //        return false;
    //    }
    //}
     class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorFortuna()); 
        }
    }
}
