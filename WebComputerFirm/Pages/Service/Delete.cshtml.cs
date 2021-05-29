using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebComputerFirm.Data;
using WebComputerFirm.Models;

namespace WebComputerFirm.Pages.Service
{
    public class DeleteModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public DeleteModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Services Services { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Services = await _context.Services.FirstOrDefaultAsync(m => m.ServiceId == id);

            if (Services == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Services = await _context.Services.FindAsync(id);

            if (Services != null)
            {
                _context.Services.Remove(Services);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
