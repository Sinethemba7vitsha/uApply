using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.DAL.Repository
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        private readonly ApplicationDbContext db;

        public GenderRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Gender gender)
        {
            var genderFromDb = db.Genders.FirstOrDefault(c => c.Id == gender.Id);

            if (genderFromDb != null)
            {
                //destrictFromDb.Name = parent.Name;

            }
        }
    }
}
