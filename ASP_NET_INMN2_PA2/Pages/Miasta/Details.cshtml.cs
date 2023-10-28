using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN2_PA2.Data;
using ASP_NET_INMN2_PA2.Models;

namespace ASP_NET_INMN2_PA2.Pages.Miasta
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_NET_INMN2_PA2.Data.ASP_NET_INMN2_PA2Context _context;

        public DetailsModel(ASP_NET_INMN2_PA2.Data.ASP_NET_INMN2_PA2Context context)
        {
            _context = context;
        }

      public Miasto Miasto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Miasta == null)
            {
                return NotFound();
            }

            var miasto = await _context.Miasta.FirstOrDefaultAsync(m => m.Id == id);
            if (miasto == null)
            {
                return NotFound();
            }
            else 
            {
                Miasto = miasto;
            }
            return Page();
        }
    }
}
