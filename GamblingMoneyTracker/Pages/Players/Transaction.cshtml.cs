using GamblingMoneyTracker.Data;
using GamblingMoneyTracker.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GamblingMoneyTracker.Pages.Players
{
    public class TransactionModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TransactionModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task OnGetAsync(int? playerId)
        {
            Player = await _context.Players.Include(x => x.Transactions)
                .FirstOrDefaultAsync(x => x.PlayerId == playerId);
        }
    }
}
