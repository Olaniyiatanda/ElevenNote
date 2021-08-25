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
        [Key]
        public int NoteId { get; set; }

        
        public Guid OwnerId { get; set; }

        [Required]
        //[Display(Name = "Your Note")]
        public String  Title { get; set; }

        //[Required]
        //[Range(1, 5, ErrorMessage = "Please choose a number between 1 and 5")]
        //[MaxLength(100, ErrorMessage = "There are too many characters in the field.")]
        public String Content { get; set; }

        [Required]
       
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

     
        
        public virtual List<Category> Categories { get; set; } = new List<Category>();
        public string Category
        {
            get;
        }
       


    }
}
