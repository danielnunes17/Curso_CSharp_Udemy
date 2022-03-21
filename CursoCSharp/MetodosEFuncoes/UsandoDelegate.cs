﻿namespace CursoCSharp.MetodosEFuncoes
{
    internal class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimeSoma(double a, double b);
        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.2));

            ImprimeSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            Func<double, double, double> op3 = MinhaSoma; //sempre o último do <> é o tipo de retorno
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7 , 23.4);

        }
    }
}
