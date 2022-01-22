using GameDemo.Abstracts;
using GameDemo.Concrates;
using GameDemo.Entities;
using System;
using GameDemo.Abstracts;
using GameDemo.MernisServiceReference;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager();
            gamerManager.SignIn(new Gamer { DateOfBirth = new DateTime(1998, 6, 10), FirstName = ("umut erdem"), LastName=("saltık"), NationalityId=(66553174018)});
            Console.ReadLine();

        }

        
        
         
        
    }
}
