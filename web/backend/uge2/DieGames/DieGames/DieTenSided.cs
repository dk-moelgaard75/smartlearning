using System;
using System.Collections.Generic;
using System.Text;

namespace DieGames
{
    class DieTenSided : IDie
    {
        public int ThrowDie()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }
    }
}
