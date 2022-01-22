using GameDemo.Abstracts;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrates
{
    public class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Id+"Added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + "Deleted!");
        }

        public void Discount(Campaign campaign)
        {
            Console.WriteLine("discounted"+campaign.Discount);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("campaign updated!"+campaign.CampaignName);
        }
    }
}
