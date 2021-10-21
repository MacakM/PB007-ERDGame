using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Guild
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Player Leader { get; set; }
        public int LeaderId { get; set; }
        public DateTime LeadersBirthDate { get; set; }
        public List<Player> Members { get; set; }
    }
}
