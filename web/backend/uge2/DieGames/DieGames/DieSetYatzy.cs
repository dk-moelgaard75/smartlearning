using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieSetYatzy : DieClass
    {
        private int NrOfDie { get; set; }
        private IDie die;
        public DieSetYatzy()
        {
            NrOfDie = 6;
            die = new DieSixSided();
        }

        public override void ThrowDie()
        {
            for (int i = 1; i <= NrOfDie; i++)
            {
                Console.WriteLine("Die #" + i.ToString() + " yielded:" + die.ThrowDie());
            }

        }
    }
}
