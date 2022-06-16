using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;

namespace uApply.DAL.Repository
{
    public class GradeRepository : Repository<Grade>, IGradeRepository
    {
        private readonly ApplicationDbContext db;

        public GradeRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Grade grade)
        {
            var gradeFromDb = db.Grades.FirstOrDefault(c => c.Id == grade.Id);

            if (gradeFromDb != null)
            {
                gradeFromDb.Name = grade.Name;
                gradeFromDb.SchoolLevel = grade.SchoolLevel;
                db.SaveChanges();
            }
        }
    }
}
