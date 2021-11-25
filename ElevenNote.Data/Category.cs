﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<Note> Notes { get; set; } = new List<Note>();
    }
}
