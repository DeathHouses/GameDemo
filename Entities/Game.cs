﻿using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game :IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}
