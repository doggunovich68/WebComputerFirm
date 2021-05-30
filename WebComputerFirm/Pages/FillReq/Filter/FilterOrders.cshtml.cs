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
    public class FilterOrdersModel : PageModel
    {
        private readonly Data.ComputerFirm_DataBaseContext _context;

        public FilterOrdersModel(Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public IList<Orders> Orders { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = _context.Customer.First(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders.Where(m => m.CustomerId == Customer.CustomerId).ToListAsync();
            return Page();
        }
    }
}
