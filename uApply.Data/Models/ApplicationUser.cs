using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; }
    }
}
