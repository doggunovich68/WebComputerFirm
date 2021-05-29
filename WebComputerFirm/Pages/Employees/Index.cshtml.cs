using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebComputerFirm.Data;
using WebComputerFirm.Models;

namespace WebComputerFirm.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public IndexModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee
                .Include(e => e.Position).ToListAsync();
        }
    }
}
