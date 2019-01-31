using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
    public class Ticket
    {
        public string Name { get; set; }
        public Address Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
