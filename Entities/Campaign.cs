using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign: IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }
    }
}
