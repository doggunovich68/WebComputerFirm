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
    public class ListComponentModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;
        public ListComponentModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }
        public IList<Component> Component { get; set; }
        public IList<TypesComponent> TypesComponent { get; set; }
        public async Task OnGetAsync()
        {
            Component = await _context.Component.ToListAsync();
            TypesComponent = await _context.TypesComponent.ToListAsync();
        }
    }
}
