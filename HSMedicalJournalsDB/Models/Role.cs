﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HSMedicalJournalsDB.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}