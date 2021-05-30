using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebComputerFirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebComputerFirm.Pages.FillReq.Filter
{
    public class FilterComponentModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public FilterComponentModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        public TypesComponent TypesComponent { get; set; }

        public IList<Component> Component { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesComponent = _context.TypesComponent.First(m => m.TypeId == id);

            if (TypesComponent == null)
            {
                return NotFound();
            }

            Component = await _context.Component.Where(m => m.TypeId == TypesComponent.TypeId).ToListAsync();
            return Page();
        }
    }
}
