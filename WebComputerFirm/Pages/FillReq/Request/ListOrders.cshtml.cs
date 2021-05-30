using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebComputerFirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Component = WebComputerFirm.Models.Component;

namespace WebComputerFirm.Pages.FillReq.Request
{
    public class ListOrdersModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public ListOrdersModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }
        public IList<Component> Component { get; set; }
        public IList<Customer> Customer { get; set; }
        public IList<Orders> Orders { get; set; }
        public IList<Services> Services { get; set; }
        public IList<Employee> Employee { get; set; }

        public async Task OnGetAsync()
        {
            Component = await _context.Component.ToListAsync();
            Customer = await _context.Customer.ToListAsync();
            Orders = await _context.Orders.ToListAsync();
            Services = await _context.Services.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
