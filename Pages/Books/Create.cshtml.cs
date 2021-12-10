﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pusok_Beata_Lab8.Data;
using Pusok_Beata_Lab8.Models;

namespace Pusok_Beata_Lab8.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Pusok_Beata_Lab8.Data.Pusok_Beata_Lab8Context _context;

        public CreateModel(Pusok_Beata_Lab8.Data.Pusok_Beata_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
