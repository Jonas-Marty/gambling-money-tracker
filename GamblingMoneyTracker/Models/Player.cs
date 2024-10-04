using System.ComponentModel.DataAnnotations;

namespace GamblingMoneyTracker.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount should be a positive number")]
        public decimal PlayMoney { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
