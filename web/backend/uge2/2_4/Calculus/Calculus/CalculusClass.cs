using System;
using System.Collections.Generic;
using System.Text;

namespace Calculus
{
    static class CalculusClass
    {
        public static void PrintTable(int tableNr)
        {
            Console.WriteLine("Table:" + tableNr);

            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine(string.Format("{0,2:##}",i) + "*" + tableNr + "=" + (i * tableNr));
            }
        }
        public static void PrintTables(int start, int end)
        {
            Console.WriteLine("Printing table from: " + start + " to " + end);
            for (int i = start; i<= end; i++)
            {
                PrintTable(i);
            }
        }
    }
}
