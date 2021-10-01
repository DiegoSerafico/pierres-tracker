using System;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public List<Order> Orders = new List<Order> {};

    public Vendor(string vendor, string description)
    {
      VendorName = vendor;
      VendorDescription = description;
    }

  }
}