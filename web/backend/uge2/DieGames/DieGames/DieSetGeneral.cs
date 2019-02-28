using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieSetGeneral : DieClass
    {
        public enum TypeOfDie { FourSided, SixSided, TenSided}
        private int NrOfDie { get; set; }
        private IDie die;
        public DieSetGeneral(int nrOfDie, TypeOfDie typeOfDie )
        {
            NrOfDie = nrOfDie;
            switch(typeOfDie)
            {
                case TypeOfDie.FourSided:
                    die = new DieFourSided();
                    break;
                case TypeOfDie.SixSided:
                    die = new DieSixSided();
                    break;
                case TypeOfDie.TenSided:
                    die = new DieTenSided();
                    break;
            }

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
