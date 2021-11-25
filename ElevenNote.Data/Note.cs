using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {

        //Primary Key
        [Key]
        public int NoteId { get; set; }

        //ForeignKey
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        // navigation property
        public virtual Category Category { get; set; } //virtual keyword tell us something can be overriden, entity framework uses this as a way to recognize the two and build that actual foreing key relationship

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
