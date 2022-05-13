using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Contracts = new HashSet<Contract>();
        }

        public int EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? QualityEducation { get; set; }
        public string? Position { get; set; }
        public string? Achievement { get; set; }
        public string? Photo { get; set; }
        public short? Status { get; set; }
        public int? AccountId { get; set; }
        public int? BusinessId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Business? Business { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
