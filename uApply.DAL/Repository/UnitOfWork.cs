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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
            District = new DistrictRepository(db);
            Parent = new ParentRepository(db);
            Title = new TitleRepository(db);
            Gender = new GenderRepository(db);
            Race = new RaceRepository(db);
            Nationality = new NationalityRepository(db);
            Language = new LanguageRepository(db);
            Learner = new LearnerRepository(db);
            Town = new TownRepository(db);
            School = new SchoolRepository(db);
            SchoolLevel = new SchoolLevelRepository(db);
            Grade = new GradeRepository(db);
            SchoolApplication = new SchoolApplicationRepository(db);
        }

        public IDistrictRepository District { get; private set; }

        public IParentRepository Parent { get; private set; }

        public ITitleRepository Title { get; private set; }

        public IGenderRepository Gender { get; private set; }

        public IRaceRepository Race { get; private set; }

        public INationalityRepository Nationality { get; private set; }

        public ILanguageRepository Language { get; private set; }

        public ILearnerRepository Learner { get; private set; }
        
        public ITownRepository Town { get; private set; }

        public ISchoolRepository School { get; private set; }

        public ISchoolLevelRepository SchoolLevel { get; private set; }

        public IGradeRepository Grade { get; private set; }

        public ISchoolApplicationRepository SchoolApplication { get; private set; }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
