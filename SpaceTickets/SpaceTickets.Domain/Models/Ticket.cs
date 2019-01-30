using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
    public class Ticket
    {
       public string Location { get; set; }
        public long Price { get; set; }
        public string Description { get; set; }
    }
}
