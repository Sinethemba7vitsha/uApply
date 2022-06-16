using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;
using uApply.Data.Models.Education;

namespace uApply.DAL.Repository
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        private readonly ApplicationDbContext db;

        public SchoolRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(School school)
        {
            var schoolFromDb = db.Schools.FirstOrDefault(c => c.Id == school.Id);

            if (schoolFromDb != null)
            {
                schoolFromDb.Name = school.Name;
                schoolFromDb.EmisNumber = school.EmisNumber;
                schoolFromDb.Town = school.Town;
                schoolFromDb.SchoolLevel = school.SchoolLevel;
                db.SaveChanges();
            }
        }
    }
}
