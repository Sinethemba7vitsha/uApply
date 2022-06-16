using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;

namespace uApply.DAL.Repository
{
    public class SchoolApplicationRepository : Repository<SchoolApplication>, ISchoolApplicationRepository
    {
        private readonly ApplicationDbContext db;

        public SchoolApplicationRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(SchoolApplication schoolApplication)
        {
            var schoolApplicationFromDb = db.SchoolApplications.FirstOrDefault(c => c.Id == schoolApplication.Id);

            if (schoolApplicationFromDb != null)
            {
                schoolApplicationFromDb.Status = schoolApplication.Status;
                db.SaveChanges();
            }
        }
    }
}
