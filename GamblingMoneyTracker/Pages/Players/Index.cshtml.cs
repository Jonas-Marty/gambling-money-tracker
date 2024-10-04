using GamblingMoneyTracker.Data;
using GamblingMoneyTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GamblingMoneyTracker.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Player> Players { get; set; }

        public async Task<IActionResult> OnGetAsync(string token)
        {
            if (token != Environment.GetEnvironmentVariable("TOKEN"))
                return RedirectToPage("/Index");
            Players = await _context.Players.Include(x => x.Transactions).ToListAsync();
            return Page();
        }
    }
}
