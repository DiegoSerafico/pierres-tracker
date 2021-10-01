using System;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> _allVendors = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendor, string description)
    {
      VendorName = vendor;
      VendorDescription = description;
      _allVendors.Add(this);
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      List<Vendor> test = new List<Vendor> {};
      return test;
    }
  }
}