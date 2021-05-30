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
    public class FilterOrdersdateModel : PageModel
    {
        private readonly Data.ComputerFirm_DataBaseContext _context;
        public FilterOrdersdateModel(Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }
        public Orders OrderOrderDate { get; set; }
        public IList<Orders> Orders { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderOrderDate = _context.Orders.First(m => m.OrderId == id);

            if (OrderOrderDate == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders.Where(m => m.OrderId == OrderOrderDate.OrderId).ToListAsync();
            return Page();
        }
    }
}
