﻿using System.Collections.Generic;

namespace DAL.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Guild GuildMember { get; set; }
        public Guild GuildLeader { get; set; }
        public List<Bag> Bags { get; set; }
        public List<Boss> KilledBosses { get; set; }
    }
}
