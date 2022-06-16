using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models.Location;

namespace uApply.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [Required]
        [DisplayName("Full Names")]
        public string FullNames { get; set; }

        [Required]
        [DisplayName("Surname")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("ID Number")]
        public long IdNumber { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [DisplayName("Street Address")]
        public string StreetAddress { get; set; }

        [Required]        
        public string Surburb { get; set; }

        [DisplayName("Postal Code")]
        public int PostalCode { get; set; }

        [ForeignKey("TownId")]
        public int TownId { get; set; }
        public Town Town { get; set; }


        //FOREIGN KEYS
        [Required]
        [DisplayName("Title")]
        [ForeignKey("TitleId")]
        public int TitleId { get; set; }
        public Title Title { get; set; }


        [Required]
        [DisplayName("Gender")]
        [ForeignKey("GenderId")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        [Required]
        [DisplayName("Nationality")]
        [ForeignKey("NationalityId")]
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

        [Required]
        [DisplayName("Race")]
        [ForeignKey("RaceId")]
        public int RaceId { get; set; }
        public Race Race { get; set; }

        [Required]
        [DisplayName("Home Language")]
        [ForeignKey("LanguageId")]//HL
        public int LanguageId { get; set; }       
        public Language Language { get; set; }


        

    }
}
