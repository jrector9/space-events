using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
    public class Payment
    {
        public long CardId { get; set; }
        public string BillAddress { get; set; }
        public long CVV { get; set; }
    }
}
