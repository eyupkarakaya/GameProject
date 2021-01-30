using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
           GamerManager gamerManager =new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1993,
                FirstName = "Eyüp",
                LastName = "Karakaya",
                IdentityNumber = 12345
            });
            Gamer gamer = new Gamer() { FirstName = "Eyüp" };
            SellProduct sellProduct = new SellProduct { ProductName = "Call Of Duty", ProductPrice = 449.90f };
            ICampignService campaigns = new CampaignManagerr();
            SellProductManager sellProductManager = new SellProductManager();
            sellProductManager.Buy(gamer);
            campaigns.CampaignEnter(new Campaigns { CampignsName = "Oyunkolik", Sale = 15, SaleTime = 3 }, sellProduct);
            campaigns.UpdateCampaign(new Campaigns { CampignsName = "Delirten Fırsat", Sale = 35, SaleTime = 7 }, sellProduct);
            campaigns.DeleteCampaign(new Campaigns { CampignsName = "OyunKolik", Sale = 15, SaleTime = 3 }, sellProduct);


        }
    }
}
