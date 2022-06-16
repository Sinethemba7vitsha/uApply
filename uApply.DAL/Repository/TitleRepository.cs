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
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        private readonly ApplicationDbContext db;

        public TitleRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Title title)
        {
            var titleFromDb = db.Titles.FirstOrDefault(c => c.Id == title.Id);

            if (titleFromDb != null)
            {
                //destrictFromDb.Name = parent.Name;
                
            }
        }
    }
}
