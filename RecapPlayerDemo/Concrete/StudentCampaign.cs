using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Concrete
{
    class StudentCampaign:ICampaignManager
    {
        public double Calculate(Game game)
        {
            return game.Price = game.Price * 0.10;
        }

        public void SaleInformation(Game game)
        {
            Console.WriteLine("Student discount !: "+game.Price +" ₺");
        }

        public void CampaignEndDate(Game game)
        {
            Console.WriteLine("End date : "+game.ReleaseYear+1);// :D
        }
    }
}
