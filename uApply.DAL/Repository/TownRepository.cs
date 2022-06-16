using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Location;

namespace uApply.DAL.Repository
{
    public class TownRepository : Repository<Town>, ITownRepository
    {
        private readonly ApplicationDbContext db;

        public TownRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Town town)
        {
            var townFromDb = db.Towns.FirstOrDefault(c => c.Id == town.Id);

            if (townFromDb != null)
            {
                townFromDb.Name = town.Name;
                db.SaveChanges();
            }
        }
    }
}
