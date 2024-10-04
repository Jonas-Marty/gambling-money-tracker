using System.ComponentModel.DataAnnotations;

namespace GamblingMoneyTracker.Models;

public class Transaction
{
    [Key]
    public int TransactionId { get; set; }

    public int PlayerId { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public string? Reason { get; set; }

    public DateTime TimeStamp { get; set; }
}