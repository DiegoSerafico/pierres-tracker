using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("Starbucks", "Starbucks Cafe");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

  }
}