using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public string? ClientIdentify { get; set; }
        public short? Status { get; set; }
        public string? NameClient { get; set; }
        public string? AddressClient { get; set; }
        public string? EmailClient { get; set; }
        public string? PhoneClient { get; set; }
        public int? BusinessId { get; set; }

        public virtual Business? Business { get; set; }
    }
}
