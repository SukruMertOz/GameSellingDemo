using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo
{
    class SellGameManager:ISellGameManager
    {
        private CampaignManager _campaignManager;

        public SellGameManager(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void Sell(Game game, Player player)
        {
            Console.WriteLine(game.GameName + " : " + "Sold to " + player.FirstName);

        }
    }
}
