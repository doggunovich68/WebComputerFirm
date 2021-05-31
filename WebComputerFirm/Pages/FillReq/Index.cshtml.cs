using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebComputerFirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebComputerFirm.Pages.FillReq
{
    public class IndexModel : PageModel
    {
        private readonly WebComputerFirm.Data.ComputerFirm_DataBaseContext _context;

        public IndexModel(WebComputerFirm.Data.ComputerFirm_DataBaseContext context)
        {
            _context = context;
        }
        //public IList<Staff> Staff { get; set; }
        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelComp { get; set; }
        public List<SelectListItem> SelOrd { get; set; }
        public List<SelectListItem> OrderData { get; set; }

        public void OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                new SelectListItem
                {
                    Value = p.PositionId.ToString(),
                    Text = p.JobTitle
                }).ToList();
            SelComp = _context.Component.Select(p =>
                new SelectListItem
                {
                    Value = p.ComponentId.ToString(),
                    Text = p.ComponentMark
                }).ToList();
            SelOrd = _context.Orders.Select(p =>
                new SelectListItem
                {
                    Value = p.OrderId.ToString(),
                    Text = p.CustomerId.ToString()
                }).ToList();
            OrderData = _context.Orders.Select(p =>
               new SelectListItem
               {
                   Value = p.OrderId.ToString(),
                   Text = p.OrderOrderDate.ToString()
               }).ToList();
        }
    }
}
