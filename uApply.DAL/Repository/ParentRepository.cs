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
    public class ParentRepository : Repository<Parent>, IParentRepository
    {
        private readonly ApplicationDbContext db;

        public ParentRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void Update(Parent parent)
        {
            var parentFromDb = db.Parents.FirstOrDefault(c => c.Id == parent.Id);

            if (parentFromDb != null)
            {
                parentFromDb.FullNames = parent.FullNames;
                parentFromDb.Surname = parent.Surname;
                parentFromDb.TitleId = parent.TitleId;
                parentFromDb.GenderId = parent.GenderId;
                parentFromDb.RaceId = parent.RaceId;
                parentFromDb.IdNumber = parent.IdNumber;
                parentFromDb.PhoneNumber = parent.PhoneNumber;
                parentFromDb.Email = parent.Email;
                parentFromDb.Password = parent.Password;
                parentFromDb.StreetAddress = parent.StreetAddress;
                parentFromDb.Surburb = parent.Surburb;
                parentFromDb.PostalCode = parent.PostalCode;
                parentFromDb.TownId= parent.TownId;
                parentFromDb.NationalityId= parent.NationalityId;
                parentFromDb.LanguageId= parent.LanguageId;
                
            }
        }
    }
}
