using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? QualityEducation { get; set; }
        public bool? Status { get; set; }
        public int? CareerId { get; set; }

        public virtual Career? Career { get; set; }
    }
}
