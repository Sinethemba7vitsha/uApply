using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;

namespace uApply.DAL.Repository
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        private readonly ApplicationDbContext db;

        public StatusRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Status status)
        {
            var statusFromDb = db.ApplicationStatuses.FirstOrDefault(c => c.Id == status.Id);

            if (statusFromDb != null)
            {
                statusFromDb.Name = status.Name;
                db.SaveChanges();
            }
        }
    }
}
