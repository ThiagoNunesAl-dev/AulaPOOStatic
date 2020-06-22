using System;

namespace AulaPOOStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("R$ 25,50 em dólares: ");
            Console.WriteLine(Conversor.ConverterRealDolar(25.50f));
            Console.WriteLine("");

            Console.WriteLine("US$ 20 em reais: ");
            Console.WriteLine(Conversor.ConverterDolarReal(20f));
            Console.WriteLine("");

            Console.WriteLine("R$ 25,50 em euros: ");
            Console.WriteLine(Conversor.ConverterRealEuro(25.50f));
            Console.WriteLine("");

            Console.WriteLine("20 euros em reais: ");
            Console.WriteLine(Conversor.ConverterEuroReal(20f));
            Console.WriteLine("");
        }
    }
}
