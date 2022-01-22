using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
        
        
    }
}
