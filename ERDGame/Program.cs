using DataAccessLayer;
using System;

namespace ERDGame
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GameDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                Console.WriteLine("Created");
            }
        }
    }
}
