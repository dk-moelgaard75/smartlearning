using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieSetFactory
    {
        public static DieSetYatzy CreateDieSetYatzy()
        {
           return new DieSetYatzy();
        }
        public static DieSetDandD CreateDieSetDandD()
        {
            return new DieSetDandD();
        }
        public static DieSetGeneral CreateDieSetGeneral(int nrOfDie,int typeOfDie)
        {
            switch (typeOfDie)
            {
                case 4:
                    return new DieSetGeneral(nrOfDie, DieSetGeneral.TypeOfDie.FourSided);
                case 6:
                    return new DieSetGeneral(nrOfDie, DieSetGeneral.TypeOfDie.SixSided);
                case 10:
                    return new DieSetGeneral(nrOfDie, DieSetGeneral.TypeOfDie.TenSided);
            }
            return new DieSetGeneral(1, DieSetGeneral.TypeOfDie.SixSided);
        }
    }
}
