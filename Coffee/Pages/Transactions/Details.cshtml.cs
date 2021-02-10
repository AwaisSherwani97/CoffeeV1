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
    public class DetailsModel : PageModel
    {
        private readonly CoffeeBeans.Models.TransactionContext _context;

        public DetailsModel(CoffeeBeans.Models.TransactionContext context)
        {
            _context = context;
        }

        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transaction = await _context.Transaction
                .Include(t => t.Product).FirstOrDefaultAsync(m => m.TransactionID == id);

            if (Transaction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
