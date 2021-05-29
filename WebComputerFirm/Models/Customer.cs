using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }
        [Display(Name = "Код Заказчика")]
        public long CustomerId { get; set; }
        [Display(Name = "ФИО")]
        public string CustomerFullName { get; set; }
        [Display(Name = "Адрес")]
        public string CustomerAddress { get; set; }
        [Display(Name = "Номер Телефона")]
        public string CustomerPhoneNumber { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
