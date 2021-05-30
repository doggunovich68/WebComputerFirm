using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebComputerFirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebComputerFirm.Pages.FillReq.Request
{
    public class PersonnelDepartmentModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public PersonnelDepartmentModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }
        public IList<Employee> Employee { get; set; }
        public IList<Position> Position { get; set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
            Position = await _context.Position.ToListAsync();
        }
    }
}
