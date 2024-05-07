using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //categoryId
        [Column(TypeName = "varchar(75)")]
        public int CategoryId {  get; set; }

        /*
        [Column(TypeName = "varchar(75)")]
        public required Category Category { get; set; }
        */

        [Column(TypeName = "varchar(75)")]
        public int Amount { get; set; }

        [Column(TypeName = "varchar(75)")]
        public string? Note { get; set; }

        [Column(TypeName = "varchar(75)")]
        public DateTime Date { get; set; } = DateTime.Now;

       

    }
}
