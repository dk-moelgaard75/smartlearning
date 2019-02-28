using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieSixSided : IDie
    {
        int IDie.ThrowDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
