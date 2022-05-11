using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Career
    {
        public int CareerId { get; set; }
        public string Offer { get; set; }     
        public string Description { get; set; }
        public string Salary { get; set; }  
        public string Requirement { get; set; }
        public string Location { get; set; }
        public string Title { get; set; } 
        public DateTime CreatedDate { get; set; }
        public bool? Status { get; set; }
    }
}
