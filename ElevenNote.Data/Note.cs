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

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

        //foreign key relationships only need to be made in data layer
        // One to many relationship, one category can have many notes
        //ForeignKey
        [ForeignKey(nameof(Category))] //can also write it as [ForeignKey("Category")], annotation is optional but reccommended because it defines control, foreign key can go on actual navigtaional property or entity itself
        //ctrl r r renames all references at once
        //ctrl shift h is find and replace, will find any matching name in project rather than specific reference as mentioned above
        public int CategoryId { get; set; }

        // navigation property
        public virtual Category Category { get; set; } //virtual keyword tell us something can be overriden, entity framework uses this as a way to recognize the two and build that actual foreing key relationship

    }
}
