using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebComputerFirm.Data;
using WebComputerFirm.Models;

namespace WebComputerFirm.Pages.TypesComponents
{
    public class DeleteModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public DeleteModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TypesComponent TypesComponent { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesComponent = await _context.TypesComponent.FirstOrDefaultAsync(m => m.TypeId == id);

            if (TypesComponent == null)
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

            TypesComponent = await _context.TypesComponent.FindAsync(id);

            if (TypesComponent != null)
            {
                _context.TypesComponent.Remove(TypesComponent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
