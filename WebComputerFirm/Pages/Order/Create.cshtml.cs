using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebComputerFirm.Data;
using WebComputerFirm.Models;

namespace WebComputerFirm.Pages.Order
{
    public class CreateModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public CreateModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

        [BindProperty]
        public Orders Orders { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Orders);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
