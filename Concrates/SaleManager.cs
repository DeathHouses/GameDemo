using GameDemo.Abstracts;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrates
{
    public class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+"bought"+game.GameName+ "for"+game.Price+"by"+campaign.Discount);
        }
    }
}
