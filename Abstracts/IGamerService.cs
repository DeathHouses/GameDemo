using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    public interface IGamerService
    {
        void SignIn(Gamer gamer);
        void DeleteGamer(Gamer gamer);
        void UpdateGamer(Gamer gamer);
    }
}
