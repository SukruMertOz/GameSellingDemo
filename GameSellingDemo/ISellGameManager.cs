using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo
{
    interface ISellGameManager
    {
        void Sell(Game game, Player player);
    }
}
