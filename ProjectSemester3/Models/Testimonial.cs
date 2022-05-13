using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Testimonial
    {
        public int TestmonialId { get; set; }
        public string? Photo { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
    }
}
