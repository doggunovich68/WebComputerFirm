using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebComputerFirm.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Orders>();
        }
        [Display(Name = "Код сотрудника")]
        public long EmployeeId { get; set; }
        [Display(Name = "ФИО")]
        public string EmployeeFullName { get; set; }
        [Display(Name = "Возраст")]
        public string EmployeeAge { get; set; }
        [Display(Name = "Пол")]
        public string EmployeeGender { get; set; }
        [Display(Name = "Адрес")]
        public string EmployeeAddress { get; set; }
        [Display(Name = "Номер телефона")]
        public string EmployeePhoneNumber { get; set; }
        [Display(Name = "Паспортные данные")]
        public string EmployeePassport { get; set; }
        [Display(Name = "Код должности")]
        public long PositionId { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
