using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieSetDandD : DieClass
    {
        private int NrOfDie { get; set; }
        private IDie die;
        public DieSetDandD()
        {
            //IN the D and D game we allways want a value between
            //1 and 100, so we allways play to tensided die.
            //the value of the first die is multiplied by ten and
            //the value of the second i added
            NrOfDie = 2;
            die = new DieTenSided();                
        }

        public override void ThrowDie()
        {
            int firstDice = (die.ThrowDie() - 1) * 10;
            int secondDice = die.ThrowDie();
            int result = firstDice + secondDice;
            Console.WriteLine("reulst:" + result.ToString());           
        }
    }
}
