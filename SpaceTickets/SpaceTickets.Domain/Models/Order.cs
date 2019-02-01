using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
    public class Order
    {
        public Address Address { get; set; }
        public Payment Payment { get; set; }
    }
}
