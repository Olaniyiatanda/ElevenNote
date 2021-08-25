using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItems
    {
        [Key]
        public int NoteId { get; set; }

        
        [MaxLength(100, ErrorMessage = "There are too many characters in the field.")]
        public String Title { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
