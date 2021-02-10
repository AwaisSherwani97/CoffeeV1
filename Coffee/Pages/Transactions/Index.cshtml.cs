using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coffee.Models;
using CoffeeBeans.Models;

namespace Coffee.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly CoffeeBeans.Models.TransactionContext _context;

        public IndexModel(CoffeeBeans.Models.TransactionContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; }

        public async Task OnGetAsync()
        {
            Transaction = await _context.Transaction
                .Include(t => t.Product).ToListAsync();
        }
    }
}
