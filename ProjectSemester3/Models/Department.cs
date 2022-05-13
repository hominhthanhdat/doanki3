using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
