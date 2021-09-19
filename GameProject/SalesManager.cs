using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Campaign campaign, Game game)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncuya " + game.Name + " adlı oyun, " + campaign.CampaignName + " kampanyalı bir şekilde satıldı.");
        }
    }
}
