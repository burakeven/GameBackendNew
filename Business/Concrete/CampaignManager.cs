using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı kampanya eklendi.");
            Console.WriteLine("Kampya indirimi: % " + campaign.CampaignDiscount);
        }

        public void Delete(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı kampanya silindi.");
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı kampanya güncenllendi.");
            Console.WriteLine("Yeni güncel kampanya indirimi: " + campaign.CampaignDiscount);
        }
    }
}
