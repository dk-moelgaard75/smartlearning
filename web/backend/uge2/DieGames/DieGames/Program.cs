using System;

namespace DieGames
{
    class Program
    {
        public string CurrentSelection { get; set; }
        static void Main(string[] args)
        {
            DisplayOptions();
        }
        static void DisplayOptions()
        {
            Console.Clear();
            Console.WriteLine("Choose between - rember <RETURN>");
            Console.WriteLine("Just die (A)");
            Console.WriteLine("Yatzy (B)");
            Console.WriteLine("Dungeons and Dragons (C)");
            Console.WriteLine("Exit (X)");
            string result = Console.ReadLine();
            HandleValue(result);

        }
        static void HandleValue(string value)
        {
            switch (value)
            {
                case "A":
                    PlayDie();
                    break;
                case "B":
                    PlayYatzy();
                    break;
                case "C":
                    PlayDandD();
                    break;
                case "X":
                    return;
                default:
                    Console.WriteLine("Unknown value");
                    DisplayOptions();
                    break;
            }

        }
        static void PlayDie()
        {
            bool doContinue = true;
            int nrOfDie = 0;
            int dieType = 0;
            Console.WriteLine("Lets just play die");
            Console.WriteLine("Type number of die - rember <RETURN>");
            string input = Console.ReadLine();
            Int32.TryParse(input, out nrOfDie);
            Console.WriteLine("Type number of sides (4,6 or 10) - rember <RETURN>");
            input = Console.ReadLine();
            Int32.TryParse(input, out dieType);
            if (nrOfDie > 0 && (dieType == 4 || dieType == 6 || dieType == 10))
            {
                DieSetGeneral set = DieSetFactory.CreateDieSetGeneral(nrOfDie, dieType);
                while (doContinue)
                {
                    set.ThrowDie();
                    Console.WriteLine("Throw again (C)");
                    Console.WriteLine("Exit (X)");
                    string result = Console.ReadLine();
                    if (result.Equals("X"))
                    {
                        doContinue = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("It was a fairly simple task - but you messed it up. Back to the main menu");
                Console.ReadLine();
            }

            DisplayOptions();
        }
        static void PlayYatzy()
        {
            bool doContinue = true;
            Console.WriteLine("Lets just play yatzy");
            DieSetYatzy set = DieSetFactory.CreateDieSetYatzy();
            while (doContinue)
            {
                set.ThrowDie();
                Console.WriteLine("Throw again (C)");
                Console.WriteLine("Exit (X)");
                string result = Console.ReadLine();
                if (result.Equals("X"))
                {
                    doContinue = false;
                }
            }
            DisplayOptions();
        }
        static void PlayDandD()
        {
            bool doContinue = true;
            Console.WriteLine("Lets just play D&D");
            DieSetDandD set = DieSetFactory.CreateDieSetDandD();
            while (doContinue)
            {
                set.ThrowDie();
                Console.WriteLine("Throw again (C)");
                Console.WriteLine("Exit (X)");
                string result = Console.ReadLine();
                if (result.Equals("X"))
                {
                    doContinue = false;
                }
            }
            DisplayOptions();
        }

    }
}
