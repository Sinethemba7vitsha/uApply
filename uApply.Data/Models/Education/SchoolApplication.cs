using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uApply.Data.Models.Education
{
    public class SchoolApplication
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("StatusId")]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;

        [Required]
        [DisplayName("School")]
        [ForeignKey("SchoolId")]
        public int SchoolId { get; set; }
        public School School { get; set; }

        [ForeignKey("LearnerId")]
        public int LearnerId { get; set; }
        public Learner Learner { get; set; }

        [Required]
        [DisplayName("Grade")]
        [ForeignKey("GradeId")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }


    }
}
