using GameDemo.Abstracts;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrates
{
    public class GameManager : BaseGamerManager
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted from db!"+game.GameName);
        }

        public void Sale(Game game,Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+ "bought"+game.GameName+"with"+ campaign.Discount +campaign.CampaignName);
        }

        public void Save(Game game)
        {
            Console.WriteLine("Game saved to db!"+game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated!"+game.GameName+game.Price);
        }
    }
}
