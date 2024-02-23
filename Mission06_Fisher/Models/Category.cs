using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Fisher.Models
{
    public class Category //This is for the Categories table in the database
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
