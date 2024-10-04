using GamblingMoneyTracker.Data;
using GamblingMoneyTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GamblingMoneyTracker.Pages.Players
{
    public class CreateTransactionModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateTransactionModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet(int? playerId)
        {
            if (playerId == null)
            {
                return NotFound();
            }

            Player = await _context.Players.FindAsync(playerId);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }

        public Player Player { get; set; }

        [BindProperty]
        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnPostAsync(int? playerId)
        {
            if (playerId is null)
            {
                return Page();
            }

            Player = await _context.Players.FindAsync(playerId.Value);
            Player.PlayMoney += Transaction.Amount;

            Transaction.TimeStamp = DateTime.Now;
            Transaction.PlayerId = playerId.Value;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Transactions.Add(Transaction);
            await _context.SaveChangesAsync();

            return RedirectToPage("/players/Transaction", new { playerId = Player.PlayerId});
        }
    }
}
