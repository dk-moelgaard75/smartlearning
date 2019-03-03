using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    static class ConverterClass
    {
        private static double ConverterValue = 7.45;
        private static double DkkToEu(double dkk)
        {
            return dkk / ConverterValue;
        }
        private static double EuToDkk(double eu)
        {
            return eu * ConverterValue;
        }
        public static double Convert(string input)
        {
            double valOut = -1;
            if (input.Contains(':'))
            {
                string[] words = input.Split(':');
                if (words[0].ToLower().Equals("eu"))
                {
                    if (double.TryParse(words[1], out valOut))
                    {
                        return EuToDkk(valOut);
                    }
                    else
                    {
                        Console.WriteLine("Værdien beløbet skal være et tal (eks: eu:34.5)");
                    }
                }
                else if (words[0].ToLower().Equals("dk"))
                {
                    if (double.TryParse(words[1], out valOut))
                    {
                        return DkkToEu(valOut);
                    }
                    else
                    {
                        Console.WriteLine("Værdien beløbet skal være et tal (eks: dk:34.5)");
                    }
                }
                else
                {
                    Console.WriteLine("Værdien " + words[0] + " er ikke valid");
                }
            }
            else
            {
                Console.WriteLine("Værdien skal være på formen eu:<beløb> eller dk:<beløb>");
            }
            return valOut;
        }
    }
}
