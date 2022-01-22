using GameDemo.Abstracts;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrates
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager()
        {
        }

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer has been deleted!" + gamer.NationalityId);
        }

        
        public override void SignIn(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.SignIn(gamer);
            }
            else
            {
                throw new Exception("not a valid person"); 
            }
            
            Console.WriteLine(gamer.FirstName+ "Signed in!");
        }

        

        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+"Updated!");
        }

        
        
    }
}
