using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;

namespace uApply.Utils.ViewModels.EducationVM
{
    public class SchoolViewModel
    {
        public School School { get; set; }
        public District District { get; set; }
        public IEnumerable<SchoolApplication> Applications { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
        public IEnumerable<SelectListItem> Towns { get; set; }
        public IEnumerable<SelectListItem> SchoolLevels { get; set; }
        public IEnumerable<SelectListItem> Grades { get; set; }
 
       
        
    }
}
