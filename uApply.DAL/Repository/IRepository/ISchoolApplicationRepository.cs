using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Education;

namespace uApply.DAL.Repository.IRepository
{
    public interface ISchoolApplicationRepository : IRepository<SchoolApplication>
    {
        void Update(SchoolApplication schoolapplication);
    }
}
