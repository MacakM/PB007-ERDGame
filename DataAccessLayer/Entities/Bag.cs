using DataAccessLayer.Enums;

namespace DAL.Entities
{
    public class Bag
    {
        public int Id { get; set; }
        public Player Owner { get; set; }
        public BagColor Color { get; set; }
        /// <summary>
        /// How many kilograms can go inside.
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Items and their weight separated with ;
        /// Example:
        /// "Silver witcher sword,2kg;Fine leather boots,1kg;Sange and Yasha,3kg"
        /// </summary>
        public string Items { get; set; }
    }
}
