using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class CategoryBusiness
    {
        public CategoryBusiness()
        {
            Businesses = new HashSet<Business>();
        }

        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }
    }
}
