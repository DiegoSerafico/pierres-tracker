using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("Starbucks", "Starbucks Cafe");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor.ClearAll();
      Vendor vendorOne = new Vendor("Starbucks", "Starbucks Cafe");
      Vendor vendorTwo = new Vendor("Suzie's", "Suzie's Cafe");
      List<Vendor> testList = new List<Vendor> {vendorOne, vendorTwo};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }

  }
}