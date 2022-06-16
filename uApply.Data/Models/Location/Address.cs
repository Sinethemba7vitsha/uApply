using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Location;

namespace uApply.Data.Models.Location
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string Surburb { get; set; }
        public int PostalCode { get; set; }

        [ForeignKey("TownId")]
        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}
