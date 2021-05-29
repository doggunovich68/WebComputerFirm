using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebComputerFirm.Data;
using WebComputerFirm.Models;

namespace WebComputerFirm.Pages.Order
{
    public class IndexModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public IndexModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders
                .Include(o => o.ComponentId1Navigation)
                .Include(o => o.ComponentId2Navigation)
                .Include(o => o.ComponentId3Navigation)
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.ServiceId1Navigation)
                .Include(o => o.ServiceId2Navigation)
                .Include(o => o.ServiceId3Navigation).ToListAsync();
        }
    }
}
