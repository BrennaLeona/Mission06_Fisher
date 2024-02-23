using System.ComponentModel.DataAnnotations;

namespace Mission06_Fisher.Models
{
    public class Form
    {
        [Key]
        public int FormID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; } //Extra Required
        [Range(1888, int.MaxValue, ErrorMessage = "Year cannot be before 1888.")] //Limit year choices
        public int Year { get; set; } //Extra Required
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; } //Extra Required
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; } //Extra Required
        [StringLength(25)] //Up to 25 characters
        public string? Notes { get; set; }
    }
}
