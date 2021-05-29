using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebComputerFirm.Data;
using WebComputerFirm.Models;

namespace WebComputerFirm.Pages.Order
{
    public class EditModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public EditModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Orders Orders { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders
                .Include(o => o.ComponentId1Navigation)
                .Include(o => o.ComponentId2Navigation)
                .Include(o => o.ComponentId3Navigation)
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.ServiceId1Navigation)
                .Include(o => o.ServiceId2Navigation)
                .Include(o => o.ServiceId3Navigation).FirstOrDefaultAsync(m => m.OrderId == id);

            if (Orders == null)
            {
                return NotFound();
            }
           ViewData["ComponentId1"] = new SelectList(_context.Services, "ServiceId", "ServiceDescription");
           ViewData["ComponentId2"] = new SelectList(_context.Services, "ServiceId", "ServiceDescription");
           ViewData["ComponentId3"] = new SelectList(_context.Services, "ServiceId", "ServiceDescription");
           ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerAddress");
           ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "EmployeeAddress");
           ViewData["ServiceId1"] = new SelectList(_context.Component, "ComponentId", "ComponentCharacteristics");
           ViewData["ServiceId2"] = new SelectList(_context.Component, "ComponentId", "ComponentCharacteristics");
           ViewData["ServiceId3"] = new SelectList(_context.Component, "ComponentId", "ComponentCharacteristics");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Orders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(Orders.OrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrdersExists(long id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
