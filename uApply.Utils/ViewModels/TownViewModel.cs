using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Location;

namespace uApply.Utils.ViewModels
{
    public class TownViewModel
    {
        public Town Town { get; set; }
        public District District { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
    }
}
