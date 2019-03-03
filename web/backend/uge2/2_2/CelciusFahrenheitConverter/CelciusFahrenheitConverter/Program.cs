using System;

namespace CelciusFahrenheitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konverter mellem celcius og fahrenheit");
            Console.WriteLine("Indtast fahr:<beløb> eller cel:<beløb>");
            string val = Console.ReadLine();
            Console.WriteLine("Resultat:" + TempConverterClass.Convert(val));
            Console.ReadLine();
        }
    }
}
