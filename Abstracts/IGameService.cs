using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrates
{
    public interface IGameService
    {
        void Save(Game game);
        void Delete(Game game);
        void Update(Game game);
        void Sale(Game game);

        
    }
}
