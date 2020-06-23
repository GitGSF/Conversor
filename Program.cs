using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dólar(US)
            System.Console.WriteLine(Conversor.RealParaDolar(100)); //dividido por 5.25
            System.Console.WriteLine(Conversor.DolarParaReais(100));//multiplica por 5.25
        
            //Euro(EUS)
            System.Console.WriteLine(Conversor.RealParaEuro(100));  //dividido por 5.92
            System.Console.WriteLine(Conversor.EuroParaReais(100)); //multiplicado por 5.92
        }
    }
}
