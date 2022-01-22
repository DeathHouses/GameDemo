using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    public abstract class BaseGamerManager : IGamerService
    {

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer has been deleted!" + gamer.NationalityId);
        }

        public virtual void SignIn(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Signed in!");
        }

        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Updated!");
        }
    }
 }