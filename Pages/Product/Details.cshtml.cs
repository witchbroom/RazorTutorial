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
    public class DetailsModel : PageModel
    {
        private readonly ContosoPets.Ui.Models.ContosoPetsContext _context;

        public DetailsModel(ContosoPets.Ui.Models.ContosoPetsContext context)
        {
            _context = context;
        }

      public Products Products { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            else 
            {
                Products = products;
            }
            return Page();
        }
    }
}
