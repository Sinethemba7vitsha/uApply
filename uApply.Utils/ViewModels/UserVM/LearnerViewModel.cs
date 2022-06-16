using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;

namespace uApply.Utils.ViewModels.UserVM
{
    public class LearnerViewModel
    {
        public Learner Learner { get; set; }
        public IEnumerable<SelectListItem> Grades { get; set; }
        public IEnumerable<SelectListItem> SchoolLevel { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
        public IEnumerable<SelectListItem> Races { get; set; }
        public IEnumerable<SelectListItem> Nationalities { get; set; }
        public IEnumerable<SelectListItem> Languages { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
        public IEnumerable<SelectListItem> Towns { get; set; }

        public District District { get; set; }

    }
}
