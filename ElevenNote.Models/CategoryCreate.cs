using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {

        public int CategoryId { get; set; }
        [MinLength(5, ErrorMessage = "Please enter at least 5 characters.")]
        [MaxLength(20, ErrorMessage = "There are too many characters in this field (Max 20).")]
        [Required]
        public string CategoryName { get; set; }
        public override string ToString() => CategoryName;
    }
}
