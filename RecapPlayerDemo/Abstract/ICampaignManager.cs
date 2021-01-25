using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Abstract
{
    interface ICampaignManager
    {
        double Calculate(Game game);  
        void SaleInformation(Game game);
        void CampaignEndDate(Game game);
    }
}
