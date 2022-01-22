using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    interface ISaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
