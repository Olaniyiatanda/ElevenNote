using ElevenNote.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Services
{
    public class NoteListItem
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public virtual Note Note { get; set; }
    }
}