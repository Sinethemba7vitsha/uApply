using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Location;

namespace uApply.Data.Models.Education
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Display(Name =  "School Name")]
        public string Name { get; set; }

        public string Email { get; set; }
        
        public string Password { get; set; }

        public long EmisNumber { get; set; }

        [ForeignKey("TownId")]
        public int TownId { get; set; }
        public Town Town { get; set; }


        [ForeignKey("SchoolLevelId")]
        public int SchoolLevelId { get; set; }
        public SchoolLevel SchoolLevel { get; set; }

        //public IEnumerable<SchoolApplication> Applications { get; set; }
    }
}
