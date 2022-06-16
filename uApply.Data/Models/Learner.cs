using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Education;
using uApply.Data.Models;

namespace uApply.Data.Models
{
    public class Learner : User
    {
        public bool IsDisabled { get; set; }

        [ForeignKey("GradeId")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        [ForeignKey("ParentId")]
        public int ParentId { get; set; }
        public Parent Parent { get; set; }

    }
}
