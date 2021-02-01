using System;

namespace GameSellingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Game game1=new Game();
           game1.GameName = "Call Of Duty Warzone";
           game1.GamePrice = 120;

            Player player2 = new Player();
            player2.FirstName = "Sena";
            player2.LastName = "Tek";
            player2.BirthYear = 1990;
            player2.IdentityNumber = "87654321";
            player2.Id = 2;

            Campaign campaign=new Campaign();
            campaign.CampaignName = "Campain of Call Of Duty Warzone";
            campaign.DiscountRate = "%15";

            CampaignManager campaignManager=new CampaignManager();
            campaignManager.Add(campaign);

            SellGameManager sellGameManager=new SellGameManager(campaignManager);
            sellGameManager.Sell(game1,player2);
        }

    }
}
