using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class TypesComponent
    {
        public TypesComponent()
        {
            Component = new HashSet<Component>();
        }
        [Display(Name = "Код Вида")]
        public long TypeId { get; set; }
        [Display(Name = "Наименование")]
        public string TypeTitle { get; set; }
        [Display(Name = "Описание")]
        public string TypeDescription { get; set; }

        public virtual ICollection<Component> Component { get; set; }
    }
}
