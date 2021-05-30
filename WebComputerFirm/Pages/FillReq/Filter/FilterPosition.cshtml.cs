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
    public class FilterPositionModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public FilterPositionModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        public Position Position { get; set; }

        public IList<Employee> Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = _context.Position.First(m => m.PositionId == id);

            if (Position == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.Where(m => m.PositionId == Position.PositionId).ToListAsync();
            return Page();
        }
    }
}
