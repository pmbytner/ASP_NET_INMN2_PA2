﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP_NET_INMN2_PA2.Data;
using ASP_NET_INMN2_PA2.Models;

namespace ASP_NET_INMN2_PA2.Pages.Miasta
{
    public class CreateModel : PageModel
    {
        private readonly ASP_NET_INMN2_PA2.Data.ASP_NET_INMN2_PA2Context _context;

        public CreateModel(ASP_NET_INMN2_PA2.Data.ASP_NET_INMN2_PA2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Miasto Miasto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Miasta == null || Miasto == null)
            {
                return Page();
            }

            _context.Miasta.Add(Miasto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
