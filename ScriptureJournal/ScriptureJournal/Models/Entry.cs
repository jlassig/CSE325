using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptureJournal.Models
{
    public class Entry
    {
        public int Id { get; set; }

        [StringLength(35, MinimumLength = 3), Required]
        public string Reference { get; set; } = string.Empty;

        [StringLength(300, MinimumLength = 10), Required, Display(Name = "Entry")]
        public string EntryText { get; set; } = string.Empty;

        [DataType(DataType.Date), Required]
        public DateTime Date { get; set; }

    }
}
