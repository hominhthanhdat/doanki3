using System;
using System.Collections.Generic;

namespace ProjectSemester3.Models
{
    public partial class Client
    {
        public Client()
        {
            Contracts = new HashSet<Contract>();
        }

        public int ClientId { get; set; }
        public string? NameClient { get; set; }
        public string? AddressClient { get; set; }
        public string? EmailClient { get; set; }
        public string? PhoneClient { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
