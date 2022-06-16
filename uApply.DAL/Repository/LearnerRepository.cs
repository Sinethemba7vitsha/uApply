using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.DAL.Repository
{
    public class LearnerRepository : Repository<Learner>, ILearnerRepository
    {
        private readonly ApplicationDbContext db;

        public LearnerRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Learner learner)
        {
            var learnerFromDb = db.Learners.FirstOrDefault(c => c.Id == learner.Id);

            if (learnerFromDb != null)
            {
                learnerFromDb.FullNames = learner.FullNames;
                learnerFromDb.Surname = learner.Surname;
                learnerFromDb.TitleId = learner.TitleId;
                learnerFromDb.GenderId = learner.GenderId;
                learnerFromDb.RaceId = learner.RaceId;
                learnerFromDb.IdNumber = learner.IdNumber;
                learnerFromDb.PhoneNumber = learner.PhoneNumber;                
                learnerFromDb.NationalityId = learner.NationalityId;
                learnerFromDb.LanguageId = learner.LanguageId;
                learnerFromDb.IsDisabled = learner.IsDisabled;                
                learnerFromDb.StreetAddress = learner.StreetAddress;                
                learnerFromDb.Surburb = learner.Surburb;                
                learnerFromDb.PostalCode = learner.PostalCode;                
                learnerFromDb.TownId = learner.TownId;

            }
        }
    }
}
