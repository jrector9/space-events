using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
    public class Payment
    {
        public Name Name { get; set; }
        public long CardId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public Address BillAddress { get; set; }
        public long CVV { get; set; }
    }
}
