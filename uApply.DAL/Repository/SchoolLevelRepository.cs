using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.DAL.Repository
{
    public class SchoolLevelRepository : Repository<SchoolLevel>, ISchoolLevelRepository
    {
        private readonly ApplicationDbContext db;

        public SchoolLevelRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(SchoolLevel schoolLevel)
        {
            var schoolLevelFromDb = db.SchoolLevels.FirstOrDefault(c => c.Id == schoolLevel.Id);

            if (schoolLevelFromDb != null)
            {
                schoolLevelFromDb.Name = schoolLevel.Name;
                db.SaveChanges();
            }
        }
    }
}
