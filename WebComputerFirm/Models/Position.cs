using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }
        [Display(Name = "Оклад")]
        public long Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Responsibilities { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }
        [Display(Name = "Наименование должности")]
        public string JobTitle { get; set; }
        [Display(Name = "Код Должности")]
        public long PositionId { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
