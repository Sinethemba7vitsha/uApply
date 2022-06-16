using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.DAL.Repository
{
    internal class NationalityRepository : Repository<Nationality>, INationalityRepository
    {
        private readonly ApplicationDbContext db;

        public NationalityRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Nationality nationality)
        {
            var nationalityFromDb = db.Nationalities.FirstOrDefault(c => c.Id == nationality.Id);

            if (nationalityFromDb != null)
            {
                //destrictFromDb.Name = parent.Name;

            }
        }
    }
}
