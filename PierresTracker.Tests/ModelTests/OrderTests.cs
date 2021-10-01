using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresTracker.Models;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOder_Order()
    {
      Order testOrder = new Order("Starbucks croisant order", "Starbucks Cafe order for croisants", 50, "10-01-2021");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

  }
}