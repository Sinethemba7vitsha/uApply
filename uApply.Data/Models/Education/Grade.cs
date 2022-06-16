using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models.Education
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("SchoolLevelId")]
        public int SchoolLevelId { get; set; }
        public SchoolLevel SchoolLevel { get; set; }

    }
}
