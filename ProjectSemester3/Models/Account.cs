using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Account
    {
        public Account()
        {
            Employees = new HashSet<Employee>();
        }

        public int AccountId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public short? Role { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
