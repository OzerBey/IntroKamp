using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Concrete
{
    class SeasonCampaign:ICampaignManager
    {
        public double Calculate(Game game)
        {
            return game.Price * 0.2;
        }

        public void SaleInformation(Game game)
        {
            Console.WriteLine("Season discount applied");
        }

        public void CampaignEndDate(Game game)
        {
            int date = game.ReleaseYear + game.ReleaseYear * (1/2);
            Console.WriteLine("End date : "+date);
        }
    }
}
