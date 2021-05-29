using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class Component
    {
        public Component()
        {
            OrdersServiceId1Navigation = new HashSet<Orders>();
            OrdersServiceId2Navigation = new HashSet<Orders>();
            OrdersServiceId3Navigation = new HashSet<Orders>();
        }
        [Display(Name = "Фирма Комплектующего")]
        public string ComponentManufacturer { get; set; }
        [Display(Name = "Код комплектующего")]
        public long ComponentId { get; set; }
        [Display(Name = "Марка")]
        public string ComponentMark { get; set; }
        [Display(Name = "Страна Производитель")]
        public string ComponentCountryManufacturer { get; set; }
        [Display(Name = "Дата выпуска")]
        public DateTime ComponentDate { get; set; }
        [Display(Name = "Описание")]
        public string ComponentDiscription { get; set; }
        [Display(Name = "Цена")]
        public string ComponentCost { get; set; }
        [Display(Name = "Характеристики")]
        public string ComponentCharacteristics { get; set; }
        [Display(Name = "Срок гарантия")]
        public long ComponentTermWarranty { get; set; }
        [Display(Name = "Код Вида")]
        public long TypeId { get; set; }

        public virtual TypesComponent Type { get; set; }
        public virtual ICollection<Orders> OrdersServiceId1Navigation { get; set; }
        public virtual ICollection<Orders> OrdersServiceId2Navigation { get; set; }
        public virtual ICollection<Orders> OrdersServiceId3Navigation { get; set; }
    }
}
