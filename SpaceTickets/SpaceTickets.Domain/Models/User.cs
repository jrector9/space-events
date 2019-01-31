using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
    public class User
    {
        public Name Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
