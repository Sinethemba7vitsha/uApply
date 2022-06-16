using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;

namespace uApply.DAL.Repository.IRepository
{
    public class RaceRepository : Repository<Race>, IRaceRepository
    {
        private readonly ApplicationDbContext db;

        public RaceRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Race race)
        {
            var raceFromDb = db.Races.FirstOrDefault(c => c.Id == race.Id);

            if (raceFromDb != null)
            {
                //destrictFromDb.Name = parent.Name;

            }
        }
    }
}
