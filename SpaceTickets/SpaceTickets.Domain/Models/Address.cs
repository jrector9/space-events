﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTickets.Domain.Models
{
  public class Address
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
  }
}
