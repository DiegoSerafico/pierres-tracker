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
    public int Id { get; }

    public Vendor(string vendor, string description)
    {
      VendorName = vendor;
      VendorDescription = description;
      _allVendors.Add(this);
      Orders = new List<Order>{};
      Id = _allVendors.Count;
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _allVendors;
    }
  }
}