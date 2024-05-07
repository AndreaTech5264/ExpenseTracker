using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "varchar(75)")]
        public required string Title { get; set; }

        [Column(TypeName = "varchar(75)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "varchar(75)")]
        public string Type { get; set; } = "Expense";

        
    }
}
