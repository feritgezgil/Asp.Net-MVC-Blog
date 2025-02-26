﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogFerit.DataEntities
{
    [Table("Categories")]
    public class Categories

    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string CategoryName { get; set; }
        [Required]
        public bool IsDelete { get; set; }
    }
}
