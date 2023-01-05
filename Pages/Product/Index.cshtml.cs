using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPets.Ui.Models;

namespace ContosoPets.Ui.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly ContosoPets.Ui.Models.ContosoPetsContext _context;

        public IndexModel(ContosoPets.Ui.Models.ContosoPetsContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Products = await _context.Products.ToListAsync();
            }
        }
    }
}
