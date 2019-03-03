using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konverter beløb mellem EU og Dk kroner");
            Console.WriteLine("Indtast eu:<beløb> eller dk:<beløb>");
            string val = Console.ReadLine();
            Console.WriteLine("Resultat:" + ConverterClass.Convert(val));
            Console.ReadLine();
        }
    }
}
