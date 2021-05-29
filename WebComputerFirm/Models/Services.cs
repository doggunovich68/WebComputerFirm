using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class Services
    {
        public Services()
        {
            OrdersComponentId1Navigation = new HashSet<Orders>();
            OrdersComponentId2Navigation = new HashSet<Orders>();
            OrdersComponentId3Navigation = new HashSet<Orders>();
        }
        [Display(Name = "Код Услуги")]
        public long ServiceId { get; set; }
        [Display(Name = "Наименование")]
        public string ServiceTitle { get; set; }
        [Display(Name = "Описание")]
        public string ServiceDescription { get; set; }
        [Display(Name = "Стоимость")]
        public long ServiceCost { get; set; }

        public virtual ICollection<Orders> OrdersComponentId1Navigation { get; set; }
        public virtual ICollection<Orders> OrdersComponentId2Navigation { get; set; }
        public virtual ICollection<Orders> OrdersComponentId3Navigation { get; set; }
    }
}
