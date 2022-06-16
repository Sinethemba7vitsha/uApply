using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;

namespace uApply.Utils.ViewModels.EducationVM
{
    public class SchoolApplicationViewModel
    {
        public SchoolApplication SchoolApplication { get; set; }
        public int ParentId { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
        public IEnumerable<SelectListItem> Towns { get; set; }
        public IEnumerable<SelectListItem> SchoolLevels { get; set; }
        public IEnumerable<SelectListItem> Schools { get; set; }
        public IEnumerable<SelectListItem> Grades { get; set; }
        public IEnumerable<SelectListItem> Statuses { get; set; }

        public District District { get; set; }
        public Town Town { get; set; }

        [DisplayName("School Level")]
        public SchoolLevel SchoolLevel { get; set; }

    }
}
