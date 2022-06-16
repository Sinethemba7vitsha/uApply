using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;

namespace uApply.Data.Models.Location
{
    public class Town
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("DistrictId")]
        public int DistrictId { get; set; }
        public District District { get; set; }
                
    }
} 
