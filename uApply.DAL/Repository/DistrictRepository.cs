
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;
using uApply.Data.Models.Location;

namespace uApply.DAL.Repository
{
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        private readonly ApplicationDbContext db;

        public DistrictRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(District district)
        {
            var destrictFromDb = db.Districts.FirstOrDefault(c => c.Id == district.Id);

            if (destrictFromDb != null)
            {
                destrictFromDb.Name = district.Name;
                db.SaveChanges();
            }
        }
    }
}
