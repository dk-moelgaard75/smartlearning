using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieFourSided : IDie
    {
        int IDie.ThrowDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 5);
        }
    }
}
