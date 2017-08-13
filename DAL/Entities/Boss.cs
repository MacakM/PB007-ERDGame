using System.Collections.Generic;

namespace DAL.Entities
{
    public class Boss
    {
        public int Id { get; set; }
        /// <summary>
        /// Bosses can have the same name in the game, but there can't
        /// be two bosses with the same name in the same location.
        /// </summary>
        public string Name { get; set; }
        public string Location { get; set; }
        /// <summary>
        /// Zip code of the location where the boss is.
        /// </summary>
        public string ZipCode { get; set; }
        public int Damage { get; set; }
        /// <summary>
        /// List of players that killed this boss.
        /// </summary>
        public List<Player> KilledByList { get; set; }
    }
}
