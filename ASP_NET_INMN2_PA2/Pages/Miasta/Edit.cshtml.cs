﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN2_PA2.Data;
using ASP_NET_INMN2_PA2.Models;

namespace ASP_NET_INMN2_PA2.Pages.Miasta
{
    public class EditModel : PageModel
    {
        private readonly ASP_NET_INMN2_PA2.Data.ASP_NET_INMN2_PA2Context _context;

        public EditModel(ASP_NET_INMN2_PA2.Data.ASP_NET_INMN2_PA2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Miasto Miasto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Miasta == null)
            {
                return NotFound();
            }

            var miasto =  await _context.Miasta.FirstOrDefaultAsync(m => m.Id == id);
            if (miasto == null)
            {
                return NotFound();
            }
            Miasto = miasto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Miasto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiastoExists(Miasto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MiastoExists(int id)
        {
          return (_context.Miasta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
