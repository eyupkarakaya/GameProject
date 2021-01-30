using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampignService
    {
        void CampaignEnter(Campaigns campaigns, SellProduct sellProduct);
        void DeleteCampaign(Campaigns campaigns, SellProduct sellProduct);
        void UpdateCampaign(Campaigns campaigns, SellProduct sellProduct);
    }
}

