using GamblingMoneyTracker.Data;
using GamblingMoneyTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GamblingMoneyTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IList<Player> Players { get; set; }

        public async Task OnGetAsync()
        {
            Players = await _context.Players.Include(x => x.Transactions).ToListAsync();
        }

    }
}
