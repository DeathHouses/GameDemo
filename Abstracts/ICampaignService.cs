using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);

        void Discount(Campaign campaign);
        void Update(Campaign campaign);
    }
}
