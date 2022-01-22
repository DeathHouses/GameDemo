using GameDemo.Abstracts;
using GameDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapters : IGamerCheckService

    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(gamer.NationalId, gamer.FirstName.ToUpper, gamer.LastName.ToUpper, gamer.DateOfBirth.Year);
        }
    }
}
