using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class Orders
    {
        [Display(Name = "Дата исполнения")]
        public DateTime OrderExecutionDate { get; set; }
        [Display(Name = "Отметка об исполнении")]
        public string OrderExecutionMark { get; set; }
        [Display(Name = "Отметка об оплате")]
        public string OrderMarkOfPayment { get; set; }
        [Display(Name = "Доля предоплаты")]
        public string OrderPrepaidShare { get; set; }
        [Display(Name = "Дата Заказа")]
        public DateTime OrderOrderDate { get; set; }
        [Display(Name = "Срок общей гарантии")]
        public long OrderGeneralWarrantyDuration { get; set; }
        [Display(Name = "Общая стоимость")]
        public long TotalCost { get; set; }
        [Display(Name = "Код Заказа")]
        public long OrderId { get; set; }
        [Display(Name = "Код Комплектующего 1")]
        public long ComponentId1 { get; set; }
        [Display(Name = "Код Комплектующего 2")]
        public long ComponentId2 { get; set; }
        [Display(Name = "Код Комплектующего 3")]
        public long ComponentId3 { get; set; }
        [Display(Name = "Код Заказчика")]
        public long CustomerId { get; set; }
        [Display(Name = "Код Сотрудника")]
        public long EmployeeId { get; set; }
        [Display(Name = "Код Услуги 1")]
        public long ServiceId1 { get; set; }
        [Display(Name = "Код Услуги 2")]
        public long ServiceId2 { get; set; }
        [Display(Name = "Код Услуги 3")]
        public long ServiceId3 { get; set; }
        [Display(Name = "Код Комплектующего 1")]
        public virtual Services ComponentId1Navigation { get; set; }
        [Display(Name = "Код Комплектующего 2")]
        public virtual Services ComponentId2Navigation { get; set; }
        [Display(Name = "Код Комплектующего 3")]
        public virtual Services ComponentId3Navigation { get; set; }
        [Display(Name = "Заказчик")]
        public virtual Customer Customer { get; set; }
        [Display(Name = "Сотрудник")]
        public virtual Employee Employee { get; set; }
        [Display(Name = "Код Услуги 1")]
        public virtual Component ServiceId1Navigation { get; set; }
        [Display(Name = "Код Услуги 2")]
        public virtual Component ServiceId2Navigation { get; set; }
        [Display(Name = "Код Услуги 3")]
        public virtual Component ServiceId3Navigation { get; set; }
    }
}
