﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uApply.Data.Models
{
    public class Title
    {           
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
