using System.ComponentModel.DataAnnotations;

namespace Mission06_Fisher.Models
{
    public class Form
    {
        [Key]
        public int FormID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        //These 3 are not required
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25)] //Up to 25 characters
        public string? Notes { get; set; }
    }
}
//Movie Form Notes:
//    Category(Miscellaneous, Drama, Television, Horror / Suspense, Comedy, Family, Action / Adventure, ?)
 //   Title(input)
   // Year(int)
//    Director(input)
  //  Rating field(G, PG, PG-13, R, NR, TV-14, TV-PG, TV-Y7, UR, TV-G, ?)
    //Edited field(yes/no) **Not required
//    Lent To(input) **Not required
  //  Notes(input - max 25 characters) * *Not required
