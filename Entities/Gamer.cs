using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Gamer
    {
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalId { get; set; }
    }
}
