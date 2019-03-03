using System;
using System.Collections.Generic;
using System.Text;

namespace CelciusFahrenheitConverter
{
    class TempConverterClass
    {
        private static double CelciusToFahr(double celcius)
        {
            return (celcius * 1.8) + 32;
        }
        private static double FahrToCelcius(double fahr)
        {
            return (fahr - 32) / 1.8;
        }
        public static double Convert(string input)
        {
            double valOut = -1;
            if (input.Contains(':'))
            {
                string[] words = input.Split(':');
                if (words[0].ToLower().Equals("fahr"))
                {
                    if (double.TryParse(words[1], out valOut))
                    {
                        return FahrToCelcius(valOut);
                    }
                    else
                    {
                        Console.WriteLine("Værdien skal være et tal (eks: fahr:34.5)");
                    }
                }
                else if (words[0].ToLower().Equals("cel"))
                {
                    if (double.TryParse(words[1], out valOut))
                    {
                        return CelciusToFahr(valOut);
                    }
                    else
                    {
                        Console.WriteLine("Værdien skal være et tal (eks: cel:34.5)");
                    }
                }
                else
                {
                    Console.WriteLine("Værdien " + words[0] + " er ikke valid");
                }
            }
            else
            {
                Console.WriteLine("Værdien skal være på formen fahr:<beløb> eller cel:<beløb>");
            }
            return valOut;
        }
    }

}

