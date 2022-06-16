using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;

namespace uApply.DAL.Repository
{
    internal class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        private readonly ApplicationDbContext db;

        public LanguageRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Language language)
        {
            var languageFromDb = db.Languages.FirstOrDefault(c => c.Id == language.Id);

            if (languageFromDb != null)
            {
                //destrictFromDb.Name = parent.Name;

            }
        }
    }
}
