using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskSite.Models
{


    public class DeskQuote
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name ="Name")]
        public string CustomerName {  get; set; } = string.Empty;

        [Display(Name ="# of Drawers")]
        public int NumDrawers {  get; set; }

        public int Width {  get; set; }
        public int Depth {  get; set; }

        public string Material {  get; set; } = string.Empty;

        [Display(Name ="Rush Order")]
        public int RushOrderChoice {  get; set; }



    }
}
